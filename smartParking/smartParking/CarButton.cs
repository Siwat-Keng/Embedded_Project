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
        
        
        private Color ready = ColorTranslator.FromHtml("#63F963");
        private Color foreReady = ColorTranslator.FromHtml("#135e31");

        private Color wait = ColorTranslator.FromHtml("#FFDC00");
        private Color foreWait = ColorTranslator.FromHtml("#ff6600");

        private Color parked = ColorTranslator.FromHtml("#fa7878");//before#F96363
        private Color foreParked = ColorTranslator.FromHtml("#F90000");
        private int transparent = 100; // transparency degree

        public Carbutton()//public Carbutton(string state)
        {
            InitializeComponent();
            this.BackColor = ready; //this.BackColor = SetColorByState(state)
            this.ForeColor = foreReady;
            
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            /*
            car.Font = new Font(car.Font.FontFamily, 20);
            Color color = Color.FromArgb
            (150, state);
            
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush
                (ClientRectangle, color, color, 10);
            pe.Graphics.FillRectangle(b, ClientRectangle);
            b.Dispose();*/
        }

        protected override Size DefaultSize
        {
            get { return new Size(70, 70); }
        }
        public override System.Drawing.Font Font
        {
            get { return car.Font = new Font("Microsoft Sans Serif", 20); }
        }

        public void Hover(EventArgs e)
        {
            OnMouseLeave(e);//แค่เอาเมาส์ออก สีก็เปลี่ยน How?
        }

        public void Ready()
        {
            this.BackColor = ready;
            this.ForeColor = foreReady;
        }
        public void Wait()
        {
            this.BackColor = wait;
            this.ForeColor = foreWait;
        }

        public void Park()
        {
            this.BackColor = parked;
            this.ForeColor = foreParked;
        }
            
        public void SetWaitState()
        {
            Wait();

        }

        public void SetParkState()
        {
            if (this.BackColor == wait)
            {
                Park();
            }
            else if (this.BackColor == ready)
            {
                Console.Beep(5000, 1000);
                MessageBox.Show("Wrong");
            }

        }
        public void SetReady()
        {
            Ready();
        }
        public void ChangeState()
        {
            //this.state = wait;
            //this.transparent = Math.Max(0,this.transparent-20);
            if (this.BackColor == ready)
            {
                Wait();
            }
            else if (this.BackColor == wait)
            {
                Park();
            }
            else
            {
                Ready();
            }
        }
        public int gett()
        {
            return this.transparent;
        }
        
        
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        private void Car_Click(object sender, EventArgs e)
        {

        }



        //ไม่ควรคลิกเมาส์บนปุ่มได้ เพราะจะไม่ถือว่าเป็น iot
        /*

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.state == ready)
            {
                this.state = wait;
            }
            else if (this.state == wait)
            {
                this.state = parked;
            }
            else
            {
                this.state = ready;
            }
        }

        
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (this.state == ready)
            {
                this.state = wait;
            }
            else if (this.state == wait)
            {
                this.state = parked;
            }
            else
            {
                this.state = ready;
            }
            
        }
        */
    }
}
