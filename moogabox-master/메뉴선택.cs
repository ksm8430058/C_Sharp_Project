using System;
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
	
    public partial class 메뉴선택 : Form
    {

		public string ID { get; set; }
		

		public 메뉴선택()
        {
            InitializeComponent();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            예매조회 frm2 = new 예매조회();
            //frm2.ShowDialog();

			this.Hide();
			frm2.Show();

			//Application.Exit();
        }

        private void btnticket_Click(object sender, EventArgs e)
        {
			if (ID == null) ID = "1";
			영화및시간선택 frm4 = new 영화및시간선택();
            //this.Visible = false;
            frm4.ID = ID;
			// frm4.ShowDialog();
			this.Hide();
			frm4.Show();
			//Application.Exit();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            매점구매창 frm9 = new 매점구매창();
			//this.Visible = false;
			//frm9.ShowDialog();
			this.Hide();
			frm9.Show();
            //Application.Exit();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
		}

		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{

		}
	}
}
