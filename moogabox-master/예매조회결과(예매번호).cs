using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace moogabox
{
    public partial class Form3 : Form
    {
        public string Reservation_Num { get; set; }

        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("SELECT MvName, StartTime, Hall, SeatNum FROM Reservation Where RsvCode = '" + Reservation_Num + "'", Conn);
            var myRead = Comm.ExecuteReader();

            if (myRead.Read())
            {
                this.lblName.Text = myRead[0].ToString();
                this.lblTime.Text = myRead[1].ToString();
                this.lblHall.Text = myRead[2].ToString();
                this.lblSeat.Text = myRead[3].ToString();

                if (myRead[0].ToString() == "닥터 스트레인지")
                {
                    pbMovie.Load(@"..\..\Resources\닥터 스트레인지.png");
                    pbMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                else if(myRead[0].ToString() == "범죄도시2")
                {
                    pbMovie.Load(@"..\..\Resources\범죄도시2.png");
                    pbMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                else if(myRead[0].ToString() == "쥬라기 월드: 도미니언")
                {
                    pbMovie.Load(@"..\..\Resources\쥬라기월드new.png");
                    pbMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            myRead.Close();
            Conn.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
			string txt = "";

			char a = '\n';

			string[] txt1 = this.lblSeat.Text.Split(a);

			for (int i = 0; i < txt1.Length; i++)
			{
				txt += txt1[i] + " ";
			}

			DialogResult OKonly = 
			MessageBox.Show("영화 : " + this.lblName.Text + "\n\n시간 : " + this.lblTime.Text + "\n\n상영관 : "
				+ this.lblHall.Text + "\n\n좌석 : " + txt + "\n\n 발권되었습니다.", "발권 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//if(OKonly == DialogResult.OK)
			//{
                this.Visible = false;
                메뉴선택 frm1 = new 메뉴선택();
                예매조회 frm2 = new 예매조회();
                frm2.Close();
				frm1.ShowDialog();
                //Application.Exit();

            //}
			

			
		}

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
