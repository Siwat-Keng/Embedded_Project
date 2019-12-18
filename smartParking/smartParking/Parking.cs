using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class Parking : Form
    {
        private List<Park> ParkList = new List<Park>();
        private string AppID = "esp8266Project";
        private string Key = "h1OlH4ta9XmFCTT";
        private string Secret = "N1Id6zGyMpyCYrunX6Z6e0Nn2";
        public Parking()
        {
            InitializeComponent();
        }

        private void Parking_Load(object sender, EventArgs e)
        {
            ParkList.Add(park1);
            ParkList.Add(park2);
            park1.SetParkNumber("1");
            park2.SetParkNumber("2");
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
    }
}
