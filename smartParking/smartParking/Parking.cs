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
        private string Key = "h1OlH4ta9XmFCTT";
        private string Secret = "N1Id6zGyMpyCYrunX6Z6e0Nn2";

        private string Alias = "VisualStudio";
        private string Target = "NodeMCU1";
        private string Topic = "/topic";
        private string parkstate= "10";
        private Boolean firststate = true;
        public Microgear microgear;

        private int k;
        private string time;
        private string price;
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
                
                this.SetParkedState();
                
                //firststate = false;
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


            //textBox2.Text = "11101";
            
            Connect2Netpie();
            /*
            ParkList.Add(park1);
            ParkList.Add(park2);
            ParkList.Add(park3);
            ParkList.Add(park4);
            ParkList.Add(park5);*/
            foreach(Park park in this.Controls.OfType<Park>())
            {
                ParkList.Add(park);
            }

            ParkList.Reverse();

            for (int i = 1; i < ParkList.Count+1; i++)
            {
                ParkList[i - 1].SetParkNumber(i.ToString());
            }
            
            //SetParkedState();

            //MessageBox.Show(ParkList[1].getState());

        }


        private void SetParkedState()//แก้ให้รับจาก parkstate
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
            /*
            if (firststate)
            {
                for (int i = 0; i < parkstate.Length; i++)
                {
                    
                    if (parkstate[i] == '0' && ParkList[i].getState()!="wait")
                    {

                        ParkList[i].Ready();
                    }
                    else if (parkstate[i] == '1')
                    {
                        ParkList[i].SetParkState(); //Parked();
                        
                    }
                }
                firststate = false;


            }
            else
            {
                for (int i = 0; i < parkstate.Length; i++)
                {
                    
                    if (parkstate[i] == '0' && ParkList[i].getState() != "wait")
                    {

                        ParkList[i].SetReadyState();
                    }
                    else if (parkstate[i] == '1')
                    {
                        ParkList[i].SetParkState();
                        
                    }
                }
            }*/
            /*
            for (int i = 0; i < 2; i++)
            {
                //MessageBox.Show(i.ToString());
                if (parkstate[i] == '1')
                {
                    k=i+1;
                    
                }
            }

            
            //MessageBox.Show(ParkList[k].GetParkNumber());
            /*
            foreach (var park in ParkList)
            {
                if (park.GetParkNumber() == k.ToString())
                {
                    park.SetParkState();
                    break;
                }
            }*/
            /*
            ParkList[k].StartCounting();
            ParkList[k].Parked();*/
            /*
            foreach (var park in ParkList)
            {
                if (park.GetParkNumber() == k.ToString())
                {
                    park.SetParkState();

                }
            }*/

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
            /*if (ParkList[i].getState() != "wait")
                    {
                        ParkList[i].SetReadyState();
                    }*/

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
                    //microgear.Chat(Target, park.GetParkNumber());
                    /*string binary = Convert.ToString(Convert.ToInt32(park.GetParkNumber()), 2);
                    microgear.Chat(Target, binary);*/
            //MessageBox.Show(binary);

            if (park.GetParkNumber() == "1")
                    {
                        //MessageBox.Show("10");
                        microgear.Chat(Target, "10");
                    }else if (park.GetParkNumber() == "2")
                    {
                        //MessageBox.Show("01");
                        microgear.Chat(Target, "01");
                    }
                    Thread.Sleep(100);
                    microgear.Chat(Target, "00");
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
                if (park.GetParkNumber() == outNo.Text.ToString() && park.getState() =="wait") //park.getState() !="ready"
                {
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
            Environment.Exit(0);
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            microgear.Chat(Alias, textBox1.Text);
        }
    }
}
