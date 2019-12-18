using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class TimeCounter : UserControl
    {
        private int hh = 0;
        private int mm = 0;
        private int ss = 0;
        private double rate = 1.0;
        public TimeCounter()
        {
            InitializeComponent();
        }
        public void StartCounting()
        {
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            SecIncrement();
            this.parkTime.Text = TimeString();
            this.price.Text = "Price : "+ TimePricing();
        }
        private void SecIncrement()
        {
            ss++;
            if (ss == 60)
            {
                ss = 0;
                MinIncrement();
            }
            
        }
        private void MinIncrement()
        {
            mm++;
            if (mm == 60)
            {
                mm = 0;
                HourIncrement();
            }
        }
        private void HourIncrement()
        {
            hh++;
        }

        private string TimeString()
        {
            string hour = hh < 10 ? "0" + hh : hh.ToString();
            string minute = mm < 10 ? "0" + mm : mm.ToString();
            string second = ss < 10 ? "0" + ss : ss.ToString();
            return hour + ":" + minute + ":" + second;
        }
        public void SpeedUp() //ลด Interval
        {
            //this.timer.Interval = (int)Math.Ceiling((double)this.timer.Interval/2) ;
            
            this.timer.Interval = Math.Max(this.timer.Interval - 250, 250);
            //this.rate = (2000.0 - (double)this.timer.Interval) / 1000.0;
            this.rate = 1000.0/(double)this.timer.Interval;
            //this.rate = Convert.ToDouble(1000.0 / (double)this.timer.Interval);
            //MessageBox.Show(rate.ToString());
        }
        public void SlowDown() //เพิ่ม Interval
        {
            
            this.timer.Interval = Math.Min(this.timer.Interval + 250, 2750);
            //this.rate = (2000.0 - (double)this.timer.Interval) / 1000.0;
            this.rate = 1000.0 / (double)this.timer.Interval;
            //this.rate = Convert.ToDouble(1000.0 / (double)this.timer.Interval);
            // MessageBox.Show(rate.ToString());
        }

        public double getRate()
        {
            return this.rate;
        }

        private double TimePricing() // จะคิดเงินลูกค้าอย่างไร
        {
            TimeSpan timeSpan = TimeSpan.Parse(parkTime.Text);
            double totalMinute = timeSpan.TotalMinutes;
            double totalPrice = Math.Floor(totalMinute) * 5; //x = Math.Round (x * 4, MidpointRounding.ToEven) / 4;
            return totalPrice;
        }
        
        public void StopCounting()
        {
            this.timer.Stop();
            this.parkTime.Text = "00:00:00";
        }

        
    }
}
