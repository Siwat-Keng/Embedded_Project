using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using io.netpie.microgear;
using System.Threading;
namespace SmartParking
{
    public partial class Parking : Form
    {
        private List<Park> ParkList = new List<Park>();
        private string AppID = "esp8266Project";
        private string Key = "caukO0rlfNLCCCV"; //"h1OlH4ta9XmFCTT"
        private string Secret = "wdB2DjD7sUDN2k2fYAPUjqvHT"; //"N1Id6zGyMpyCYrunX6Z6e0Nn2";
        private string Alias = "VisualStudio";
        private string Target = "NodeMCU1";
        private string Topic = "/topic";
        private string parkstate= "10";
        public Microgear microgear;
        private string time;
        private string price;
        public void Connect()
        {
            if (connectStatus.Text == "Disconnect")
            {
                MessageBox.Show("Connecting");
            }
        }
        public void Message(string topic,string message)
        {
            if (connectStatus.Text == "Connected")
            {
                parkstate = message;
                this.SetParkedState();
            }
        }
        public void Present(string token)
        {
            if (connectStatus.Text == "Connected")
            {
                MessageBox.Show(token);
            }
        }
        public void Absent(string token)
        {
            if (connectStatus.Text == "Connected")
            {
                MessageBox.Show(token);
            }

        }
        public void Error(string error)
        {

            if (connectStatus.Text == "Connected")
            {
                MessageBox.Show(error);
            }
        }
        public void Info(string info)
        {
            if (connectStatus.Text == "Connected")
            {
                MessageBox.Show(info);
            }
        }
        public void Connect2Netpie()
        {
            if (connectStatus.Text == "Disconnect")
            {
                connectStatus.Text = "Connected"; //Connect to netpie
                MessageBox.Show("Connected");
            }
            else
            {
                connectStatus.Text = "Connected";
            }
        }

        public Parking()
        {
            InitializeComponent();
        }

        

        private void Parking_Load(object sender, EventArgs e)
        {
            microgear = new Microgear();
            microgear.onConnect += Connect;
            microgear.onMessage += Message;
            microgear.onPresent += Present;

            microgear.onError += Error;

            microgear.onInfo += Info;
            microgear.Connect(AppID, Key, Secret);
            microgear.SetAlias(Alias);
            microgear.Subscribe(Topic);
            microgear.onAbsent += Absent;
            Connect2Netpie();
            foreach(Park park in this.Controls.OfType<Park>())
            {
                ParkList.Add(park);
            }
            ParkList.Reverse();

            for (int i = 1; i < ParkList.Count+1; i++)
            {
                ParkList[i - 1].SetParkNumber(i.ToString());
            }
        }


        private void SetParkedState()
        {
            for (int i = 0; i < parkstate.Length; i++)
            {
                if (parkstate[i] == '1')
                {
                    ParkList[i].SetParkState();

                }
                else if (parkstate[i] == '0')
                {
                    if (ParkList[i].getState() == "parked")
                    {
                        ParkList[i].SetWaitState();
                        ParkList[i].StopCounting();
                        if (i == 1)
                        {
                            microgear.Chat(Target, "01");
                        }
                        else if (i == 0)
                        {
                            microgear.Chat(Target, "10");
                        }
                        else if (parkstate == "00")
                        {
                            microgear.Chat(Target, "11");
                        }
                    }
                }
            }
        }
        private void Parking_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var park in ParkList)
            {
                park.ShowPark();
            }
        }

        

        private void SlowBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                park.SlowDown();
                
            }
            rate.Text = park1.getRate().ToString("n2");
        }

        private void SpdBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                park.SpeedUp();
            }
            rate.Text = park1.getRate().ToString("n2");
        }

        //Simulate Embeded System
        private void CarInBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                if (park.getState() == "ready")
                {
                    park.SetWaitState();
                    MessageBox.Show("Go to park no. "+park.GetParkNumber(),"Nearest park");
                    

            if (park.GetParkNumber() == "1")
                    {
                        
                        microgear.Chat(Target, "10");
                    }else if (park.GetParkNumber() == "2")
                    {
                        
                        microgear.Chat(Target, "01");
                    }
                    Thread.Sleep(100);
                    microgear.Chat(Target, "00");
                    break;
                }
            }
        }

        

        private void CarOutBtn_Click(object sender, EventArgs e)
        {
            
            foreach (var park in ParkList)
            {
                if (park.GetParkNumber() == outNo.Text.ToString() && park.getState() =="wait") //park.getState() !="ready"
                {
                    if (park.GetParkNumber() == "1")
                    {
                        microgear.Chat(Target, "20");
                    }else if (park.GetParkNumber() == "2")
                    {
                        microgear.Chat(Target, "02");
                    }
                        price = park.GetPrice();
                    time = park.GetTime();
                    park.SetReadyState();
                    MessageBox.Show("Park No." + outNo.Text + "\n"
                + "Park time " + time + "\n"
                + "Price " + price + " Baht"
                , "Receipt");
                }
            }
            
        }

        

        private void Parking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);//เมื่อปิดไปแล้วโปรแกรมยังคงทำงานอยู่ใน task จึงต้องมี event นี้
        }

        

        

        private void Button3_Click(object sender, EventArgs e)
        {
            microgear.Chat(Alias, textBox1.Text);
            textBox1.Text = "";
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.D0, Keys.D1 };
            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }
    }
}
