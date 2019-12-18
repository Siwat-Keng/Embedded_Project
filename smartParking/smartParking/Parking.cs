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

namespace SmartParking
{
    public partial class Parking : Form
    {
        private List<Park> ParkList = new List<Park>();
        private string AppID = "esp8266Project";
        private string Key = "h1OlH4ta9XmFCTT";
        private string Secret = "N1Id6zGyMpyCYrunX6Z6e0Nn2";

        private string Alias = "VisualStudio";
        private string Target = "NodeMCU1";
        private string Topic = "/topic";
        private string parkstate= "00";
        private Boolean firststate = true;
        public Microgear microgear;

        public void Connect()
        {
            if (connectStatus.Text == "Disconnect")
            {
                //Console.WriteLine("Connecting");
                MessageBox.Show("Connecting");
            }
        }
        public void Message(string topic,string message)
        {
            
            if (connectStatus.Text == "Connected")
            {
                //Console.WriteLine(topic+" "+message);
                //textBox1.Invoke(new Action(() => textBox1.AppendText(message + Environment.NewLine)));
                parkstate = message;
                //MessageBox.Show(parkstate);

                SetParkState();
                firststate = false;
            }
        }
        //ครั้งแรก setparkstate รับ ครั้ง 2 ต้องตรวจว่าไปจอดตรงไหน จอดถูกกฎมั้ย
        public void Present(string token)

        {

            if (connectStatus.Text == "Connected")

            {

                //Console.WriteLine(token);
                MessageBox.Show(token);
            }

        }
        public void Absent(string token)

        {

            if (connectStatus.Text == "Connected")

            {

                //Console.WriteLine(token);
                MessageBox.Show(token);
            }

        }
        public void Error(string error)

        {

            if (connectStatus.Text == "Connected")

            {

                //Console.WriteLine(error);
                MessageBox.Show(error);
            }

        }
        public void Info(string info)

        {

            if (connectStatus.Text == "Connected")

            {

                //Console.WriteLine(info);
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


            //textBox2.Text = "11";
            
            Connect2Netpie();

            ParkList.Add(park1);
            ParkList.Add(park2);
            park1.SetParkNumber("1");
            park2.SetParkNumber("2");

            SetParkState();
            //MessageBox.Show(ParkList[1].getState());

        }


        private void SetParkState()//แก้ให้รับจาก parkstate
        {
            /*
            if (firststate)
            {
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    
                    if (textBox2.Text[i] == '0')
                    {

                        ParkList[i].Ready();
                    }
                    else if (textBox2.Text[i] == '1')
                    {
                        ParkList[i].Parked();
                        ParkList[i].StartCounting();
                    }
                }
                firststate = false;
            }
            else
            {
                for (int i = 0; i < textBox2.TextLength; i++)
                {
                    if (textBox2.Text[i] == '0')
                    {

                        ParkList[i].SetReadyState();
                    }
                    else if (textBox2.Text[i] == '1')
                    {
                        ParkList[i].SetParkState();
                    }
                }
            }*/
            if (firststate)
            {
                for (int i = 0; i < parkstate.Length; i++)
                {

                    if (parkstate[i] == '0')
                    {

                        ParkList[i].Ready();
                    }
                    else if (parkstate[i] == '1')
                    {
                        ParkList[i].Parked();
                        ParkList[i].StartCounting();
                    }
                }
                
            }
            else
            {
                for (int i = 0; i < parkstate.Length; i++)
                {
                    if (textBox2.Text[i] == '0')
                    {

                        ParkList[i].SetReadyState();
                    }
                    else if (textBox2.Text[i] == '1')
                    {
                        ParkList[i].SetParkState();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            park1.StartCounting();
        }

        private void SlowBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                park.SlowDown();
                
            }
            rate.Text = park1.getRate().ToString();
        }

        private void SpdBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                park.SpeedUp();
            }
            rate.Text = park1.getRate().ToString();
        }

        //Simulate Embeded System
        private void CarInBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                if (park.getState() == "ready")
                {
                    park.SetWaitState();
                    break;
                }
            }
        }

        private void CarParkBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                if (park.GetParkNumber() == parkNo.Text.ToString())
                {
                    park.SetParkState();
                }
            }
        }

        private void CarOutBtn_Click(object sender, EventArgs e)
        {
            foreach (var park in ParkList)
            {
                if (park.GetParkNumber() == outNo.Text.ToString())
                {
                    park.SetReadyState();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            microgear.Chat(Target, "On");
        }

        private void Parking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            /*
            if (!firststate)
            {
                SetParkState();
            }
            */
            parkstate = textBox2.Text;
            SetParkState();
        }
    }
}
