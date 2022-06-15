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
    public partial class 관리자_첫화면 : Form
    {
        public 관리자_첫화면()
        {
            InitializeComponent();

            var CurrentDirectory = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(CurrentDirectory, @"..\..\Image\KakaoTalk_20220525_141938370.png"));
            pictureBox1.Load(newPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn_Stock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_재고메뉴선택창 M_frm3 = new 관리자_재고메뉴선택창();
            M_frm3.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            로그인 frm0 = new 로그인();
            frm0.ShowDialog();
            Application.Exit();
        }

        private void Btn_Sale_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_총매출창 M_frm2 = new 관리자_총매출창();
            M_frm2.ShowDialog();
            Application.Exit();
        }

		private void ManagerForm1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
