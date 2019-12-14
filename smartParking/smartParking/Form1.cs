using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace smartParking
{
    public partial class Form1 : Form
    {
        int click = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            carButton car = new carButton();
           
            
        }

        private void CarButton1_Click(object sender, EventArgs e)
        {
            carButton car = new carButton();
            car.Button1_Click(sender,e);
        }
    }
}
