using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moogabox.UserControls
{
    public partial class UC_Drink : UserControl
    {
        public event EventHandler Button1_Evnet;
        public event EventHandler Button2_Evnet;
        public event EventHandler Button3_Evnet;
        public event EventHandler Button4_Evnet;

        public UC_Drink()
        {
            InitializeComponent();

            btnDrink1.Click += btnDrink1_Click_Event;
            btnDrink2.Click += btnDrink2_Click_Event;
            btnDrink3.Click += btnDrink3_Click_Event;
            btnDrink4.Click += btnDrink4_Click_Evnet;
        }

        public void btnDrink1_Click_Event(object sender, EventArgs e)
        {
            if (this.Button1_Evnet != null)
                Button1_Evnet(sender, e);
        }

        public void btnDrink2_Click_Event(object sender, EventArgs e)
        {
            if (this.Button2_Evnet != null)
                Button2_Evnet(sender, e);
        }

        public void btnDrink3_Click_Event(object sender, EventArgs e)
        {
            if (this.Button3_Evnet != null)
                Button3_Evnet(sender, e);
        }

        public void btnDrink4_Click_Evnet(object sender, EventArgs e)
        {
            if (this.Button4_Evnet != null)
                Button4_Evnet(sender, e);
        }
    }
}
