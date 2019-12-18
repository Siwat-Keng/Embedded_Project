using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class Park : UserControl
    {
        private string state;
        private Color ready = ColorTranslator.FromHtml("#63F963");
        private Color foreReady = ColorTranslator.FromHtml("#135e31");

        private Color wait = ColorTranslator.FromHtml("#FFDC00");
        private Color foreWait = ColorTranslator.FromHtml("#ff6600");

        private Color parked = ColorTranslator.FromHtml("#fa7878");//before#F96363
        private Color foreParked = ColorTranslator.FromHtml("#F90000");

        private Boolean counting = false;
        private int waitsec;
        public Park()
        {
            InitializeComponent();
            this.state = "ready";
            this.carPark.BackColor = ready;
            this.carPark.ForeColor = foreReady;

            this.carPark.FlatStyle = FlatStyle.Flat;
            this.carPark.FlatAppearance.BorderSize = 0;
        }
        public void SetParkNumber(string number)
        {
            this.carPark.Text = number;
        }
        public string GetParkNumber()
        {
            return this.carPark.Text;
        }

        public void Ready()
        {
            this.state = "ready";
            this.carPark.BackColor = ready;
            this.carPark.ForeColor = foreReady;
        }
        public void Wait()
        {
            this.state = "wait";
            this.carPark.BackColor = wait;
            this.carPark.ForeColor = foreWait;
        }

        public void Parked()
        {
            this.state = "parked";
            this.carPark.BackColor = parked;
            this.carPark.ForeColor = foreParked;
        }

        public void SetWaitState()
        {
            waitTimer.Start();
            Wait();

        }

        public void SetParkState()
        {
            //MessageBox.Show("Park.setParkstate");
            if (this.state == "wait")
            {
                Parked();
                this.StartCounting();
            }
            else if (this.state == "ready")
            {
                
                Thread thread = new Thread(() => {
                    this.BeginInvoke((Action)delegate () {
                        StartBeep();
                    });
                });
                thread.Start();
                MessageBox.Show("Park No."+this.GetParkNumber() + " " + "is Parked on ready state");

                //BeepSound();//WrongState ต้องแก้เป้น while true รับสถานะที่จอดรถเรื่อยๆ ถ้ารถออกไปแล้วค่อยหยุด
            }
            

        }
        public void StopCounting()
        {
            this.timeCounter.StopCounting();
            this.counting = false;
        }
        public void SetReadyState()
        {
            Ready();
            this.timeCounter.StopCounting();
            this.timeCounter.reset(); //
            this.counting = false;

        }

        private void BeepSound()
        {
            /*for (int i = 0; i < 5; i++)
            {
                Console.Beep(1000, 500);
            }*/
            Console.Beep(300, 3000);
            //MessageBox.Show("Wrong");
        }
        public void StartCounting()
        {
            if (!counting) {
                counting = true;
            this.timeCounter.StartCounting();
            }
        }

        public void SpeedUp()
        {
            this.timeCounter.SpeedUp();
        }

        public void SlowDown()
        {
            this.timeCounter.SlowDown();
        }
        private void CarPark_MouseClick(object sender, MouseEventArgs e)
        {
            this.carPark.Visible = false;
        }
        public void ShowPark()
        {
            this.carPark.Visible = true;
        }

        public double getRate()
        {
            return this.timeCounter.getRate();
        }
        
        public string getState()
        {
            return this.state;
        }
        private void StartBeep()
        {
            beepCounter.Start();
            //BeepSound();
        }
        private void BeepCounter_Tick(object sender, EventArgs e)
        {
            BeepSound();
            beepCounter.Stop();
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            waitsec++;
            /*
            if (waitsec == 10)
            {
                waitTimer.Stop();
                waitsec = 0;
                Ready();
            }*/
           
        }
        public string GetTime()
        {
            return this.timeCounter.GetTime();
        }

        public string GetPrice()
        {
            return this.timeCounter.TimePricing().ToString();
        }
    }
}
