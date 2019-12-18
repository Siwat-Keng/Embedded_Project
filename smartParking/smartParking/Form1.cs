using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


using io.netpie.microgear;

namespace SmartParking
{
    public partial class Form1 : Form
    {
        
        private string AppID = "esp8266Project";
        private string Key = "h1OlH4ta9XmFCTT";
        private string Secret = "N1Id6zGyMpyCYrunX6Z6e0Nn2";


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
            
            
        }


        private void Button2_Click(object sender, EventArgs e) //จอด
        {
           
        }

        private void Button3_Click(object sender, EventArgs e) //ว่าง
        {
           

        }

        private void Button1_Click(object sender, EventArgs e)//จอง
        {
            
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text + Environment.NewLine;
        }

        private void Carbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
