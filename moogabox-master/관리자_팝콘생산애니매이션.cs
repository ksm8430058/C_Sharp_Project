using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace moogabox
{
    public partial class 관리자_팝콘생산애니매이션 : Form
    {
        Timer timer1 = new Timer();

        public 관리자_팝콘생산애니매이션()
        {
            InitializeComponent();
            timer1.Interval = 40;
            timer1.Tick += timer2_Tick;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Start();
            ////////////////////
            var CurrentDirectory = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(CurrentDirectory, @"..\..\Media\PopCorn.gif"));
            pictureBox1.Load(newPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value++;
                label1.Text = progressBar1.Value.ToString();
               
            }
            else
            {
                timer1.Stop();
                this.Visible = false;
            }
        }

		private void ManagerForm6_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
		}
	}
}
