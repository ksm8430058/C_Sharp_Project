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
    public partial class UC_Set : UserControl
    {
        public event EventHandler Button1_Evnet;
        public event EventHandler Button2_Evnet;
        public event EventHandler Button3_Evnet;
        public event EventHandler Button4_Evnet;

        public UC_Set()
        {
            InitializeComponent();

            btnSet1.Click += btnSet1_Click_Event;
            btnSet2.Click += btnSet2_Click_Event;
            btnSet3.Click += btnSet3_Click_Event;
            btnSet4.Click += btnSet4_Click_Evnet;
        }

        public void btnSet1_Click_Event(object sender, EventArgs e)
        {
            if (this.Button1_Evnet != null)
                Button1_Evnet(sender, e);
        }

        public void btnSet2_Click_Event(object sender, EventArgs e)
        {
            if (this.Button2_Evnet != null)
                Button2_Evnet(sender, e);
        }

        public void btnSet3_Click_Event(object sender, EventArgs e)
        {
            if (this.Button3_Evnet != null)
                Button3_Evnet(sender, e);
        }

        public void btnSet4_Click_Evnet(object sender, EventArgs e)
        {
            if (this.Button4_Evnet != null)
                Button4_Evnet(sender, e);
        }
    }
}
