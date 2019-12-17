using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class Park : UserControl
    {
        public Park()
        {
            InitializeComponent();
        }
        public void ChangeText(string number)
        {
            this.carbutton1.Text = number;
        }
        public void ChangeState()
        {
            this.carbutton1.ChangeState();
        }
        public Carbutton car()
        {
            return carbutton1;
        }

        
    }
}
