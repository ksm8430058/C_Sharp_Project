using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using moogabox;

namespace moogabox.UserControls
{
    public partial class UC_Popcorn : UserControl
    {
        public event EventHandler Button1_Evnet;
        public event EventHandler Button2_Evnet;
        public event EventHandler Button3_Evnet;
        public event EventHandler Button4_Evnet;

        public UC_Popcorn()
        {
            InitializeComponent();

            btnPopcorn1.Click += btnPopcorn1_Click_Event;
            btnPopcorn2.Click += btnPopcorn2_Click_Event;
            btnPopcorn3.Click += btnPopcorn3_Click_Event;
            btnPopcorn4.Click += btnPopcorn4_Click_Evnet;
        }

        public void btnPopcorn1_Click_Event(object sender, EventArgs e)
        {
            if (this.Button1_Evnet != null)
                Button1_Evnet(sender, e);
        }

        public void btnPopcorn2_Click_Event(object sender, EventArgs e)
        {
            if (this.Button2_Evnet != null)
                Button2_Evnet(sender, e);
        }

        public void btnPopcorn3_Click_Event(object sender, EventArgs e)
        {
            if (this.Button3_Evnet != null)
                Button3_Evnet(sender, e);
        }

        public void btnPopcorn4_Click_Evnet(object sender, EventArgs e)
        {
            if (this.Button4_Evnet != null)
                Button4_Evnet(sender, e);
        }

    }
}
