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
    public partial class 관리자_재고메뉴선택창 : Form
    {
        public 관리자_재고메뉴선택창()
        {
            InitializeComponent();

            var CurrentDirectory = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(CurrentDirectory, @"..\..\Image\KakaoTalk_20220525_141938370.png"));
            pictureBox1.Load(newPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn_StoreStock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_재고관리창 M_frm4 = new 관리자_재고관리창();
            M_frm4.ShowDialog();
            Application.Exit();
        }

        private void Btn_WarehouseStock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_발주관리창 M_frm5 = new 관리자_발주관리창();
            M_frm5.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_첫화면 M_frm1 = new 관리자_첫화면();
            M_frm1.ShowDialog();
            Application.Exit();
        }

        bool TagMove;
        int MvalX, MValY;

		private void ManagerForm3_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MvalX = e.X;
            MValY = e.Y;
        }
    }
}
