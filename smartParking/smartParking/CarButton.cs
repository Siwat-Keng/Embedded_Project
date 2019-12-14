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
    public partial class Carbutton : System.Windows.Forms.Button
    {
        private Color state;
        private Color ready = Color.Lime;
        private Color wait = Color.Orange;
        private Color parked = Color.Red;
        private int transparent = 100; // transparency degree 
                                              
        
        public Carbutton()
        {
            InitializeComponent();
            car.BackColor = Color.Lime;
            this.state = ready;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Color color = Color.FromArgb
            (transparent, state);
            
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush
                (ClientRectangle, color, color, 10);
            pe.Graphics.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }

        public void Car_Click(object sender, EventArgs e)
        {
            this.state = wait;
            MessageBox.Show("ok");
        }
    }
}
