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
        public Form1()
        {
            InitializeComponent();
            Carbutton carbutton = new Carbutton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Carbutton1_Click(object sender, EventArgs e)
        {
            carbutton1.Car_Click(sender, e);
        }
    }
}
