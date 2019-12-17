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
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();

            /*
            List<Carbutton> CarList = new List<Carbutton>();
            AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));
            AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));
            AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));*/
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            park1.ChangeText("1");
            park2.ChangeText("2");



            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(Object sender,EventArgs e)
        {
            int h = 0;
            int m = 0;
            int s = 0;

            string time = "";

            string hour = h < 10 ? "0" : "";
            string minute = m < 10 ? "0" : "";
            string sec = s < 10 ? "0" : "";

            time = hour + h + ":" + minute + m + ":" + sec + s;
        }

        private void Button2_Click(object sender, EventArgs e) //จอด
        {
            park1.car().SetParkState();
        }

        private void Button3_Click(object sender, EventArgs e) //ว่าง
        {
            park1.car().SetReady();

        }

        private void Button1_Click(object sender, EventArgs e)//จอง
        {
            park1.car().SetWaitState();
        }
    }
}
