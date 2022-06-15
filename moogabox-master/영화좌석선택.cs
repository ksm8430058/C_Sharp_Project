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

namespace moogabox
{
    public partial class 영화좌석선택 : Form
    {
		private string Constr = "Server=(local);database=MoogaBox;" +
                "Integrated Security=true"; //SQL 연결문자열
        public 영화좌석선택()
        {
            InitializeComponent();
        }
        int count = 0;
        public string Passvalue { get; set; }
		public string ID { get; set; }
        string joasuk = "";

        private void Form5_Load(object sender, EventArgs e)
        {
			if (ID == null) ID = "1";
			joasuk = "";
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("Select MvName,Hall,StartTime from TmpReservation", Conn);
            var myRead = Comm.ExecuteReader();
            if (myRead.Read())
            {
                this.lblName.Text = myRead[0].ToString();
                this.lblTime.Text = myRead[2].ToString();
                this.lblhall.Text = myRead[1].ToString();
            }
            myRead.Close();
           
            var Comm1 = new SqlCommand("SELECT Eempty FROM Crjo where MvNum = '" + Passvalue + "'", Conn);
            var MyRead1 = Comm1.ExecuteReader();

            //MessageBox.Show(Passvalue);
            int[] Eempty = new int[20];

            int i = 0;
            while (MyRead1.Read())
            {
                Eempty[i] = Convert.ToInt32(MyRead1[0]);
                i++;
            }

            MyRead1.Close();
            Conn.Close();
            Seat(Eempty);
            MessageBox.Show("최대 선택 좌석은 4개입니다.", "주의사항",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnA1_Click_1(object sender, EventArgs e)
        {
            if (btnA1.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);       
            }
            else
            {
                if (count < 4)
                {

                    label2.Text += "A01\n";
                    btnA1.BackColor = Color.White;
                    btnA1.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "A01,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            }
        private void btnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "A02\n";
                    btnA2.BackColor = Color.White;
                    btnA2.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "A02,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "A03\n";
                    btnA3.BackColor = Color.White;
                    btnA3.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "A03,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
         private void btnA4_Click(object sender, EventArgs e)
        {
            if (btnA4.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "A04\n";
                    btnA4.BackColor = Color.White;
                    btnA4.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "A04,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (btnA5.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "A05\n";
                    btnA5.BackColor = Color.White;
                    btnA5.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "A05,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnB1_Click_1(object sender, EventArgs e)
        {
            if (btnB1.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "B01\n";
                    btnB1.BackColor = Color.White;
                    btnB1.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "B01,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "B02\n";
                    btnB2.BackColor = Color.White;
                    btnB2.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "B02,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "B03\n";
                    btnB3.BackColor = Color.White;
                    btnB3.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "B03,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (btnB4.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "B04\n";
                    btnB4.BackColor = Color.White;
                    btnB4.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "B04,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (btnB5.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "B05\n";
                    btnB5.BackColor = Color.White;
                    btnB5.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "B05,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "C01\n";
                    btnC1.BackColor = Color.White;
                    btnC1.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "C01,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "C02\n";
                    btnC2.BackColor = Color.White;
                    btnC2.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "C02,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "C03\n";
                    btnC3.BackColor = Color.White;
                    btnC3.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "C03,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (btnC4.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "C04\n";
                    btnC4.BackColor = Color.White;
                    btnC4.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "C04,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (btnC5.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "C05\n";
                    btnC5.BackColor = Color.White;
                    btnC5.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "C05,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (btnD1.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "D01\n";
                    btnD1.BackColor = Color.White;
                    btnD1.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "D01,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnD2_Click(object sender, EventArgs e)
        {
            if (btnD2.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "D02\n";
                    btnD2.BackColor = Color.White;
                    btnD2.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "D02,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            if (btnD3.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "D03\n";
                    btnD3.BackColor = Color.White;
                    btnD3.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "D03,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if (btnD4.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "D04\n";
                    btnD4.BackColor = Color.White;
                    btnD4.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "D04,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            if (btnD5.BackColor == Color.White)
            {
                MessageBox.Show("좌석 중복불가.", "좌석선택오류",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (count < 4)
                {
                    label2.Text += "D05\n";
                    btnD5.BackColor = Color.White;
                    btnD5.ForeColor = Color.Black;
                    count++;
                    label3.Text = Convert.ToString(count);
                    joasuk += "D05,";
                }
                else if (count >= 4)
                {
                    MessageBox.Show("최대 선택가능 좌석은 4개입니다.", "좌석선택오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnPeople_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button[] Button = { btnA1, btnA2, btnA3, btnA4, btnA5,
                                btnB1, btnB2, btnB3, btnB4, btnB5,
                                btnC1, btnC2, btnC3, btnC4, btnC5,
                                btnD1, btnD2, btnD3, btnD4, btnD5};
			var Conn = new SqlConnection(Constr);
			Conn.Open();

           
			var Comm1 = new SqlCommand("SELECT Eempty FROM Crjo where MvNum = '" + Passvalue + "'", Conn);
			var MyRead1 = Comm1.ExecuteReader();

			int[] Eempty = new int[20];

			int i = 0;
			while (MyRead1.Read())
			{
				Eempty[i] = Convert.ToInt32(MyRead1[0]);
				i++;
			}

			MyRead1.Close();

			for (int j = 0; j < 20; j++)
            {
				if (Eempty[j] == 0)
				{
					Button[j].BackColor = Color.Black;
					Button[j].ForeColor = Color.White;
				}
			}

            Conn.Close();

            label2.Text = "";
            label3.Text = "";
            joasuk = "";
            count = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //첫 창으로 이동
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            var Comm = new SqlCommand("delete from TmpReservation", Conn);
            Comm.ExecuteNonQuery();

            Conn.Close();

            메뉴선택 form1 = new 메뉴선택();
            form1.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //label2.Text
            var Conn = new SqlConnection(Constr);
            Conn.Open();

            string Tmp_text = joasuk;
            char sp = ',';

            string[] strtmp = Tmp_text.Split(sp);
        
            int hallnum = Convert.ToInt32(this.lblhall.Text);
            string txt = "";
			string txt1 = "";

            for(int i = 0; i < strtmp.Length;)
            {
                txt1 += "'" + strtmp[i] + "'" ;
				txt += strtmp[i];
				i++;
				if (i >= strtmp.Length - 1) break;
				else txt1 += ",";

			}
			
            for (int i = 0; i < strtmp.Length; i++)
            {
                string sql = "UPDATE Crjo set Eempty =" + 1 + "WHERE MvNum = '" + Passvalue + "' and SeatNum = '" + strtmp[i] + "'";
                var Comm = new SqlCommand(sql, Conn);
                Comm.ExecuteNonQuery();
            }

            string Sql = "update TmpReservation set SeatNum ="
                                  + "@SeatNum" + " select hall from TmpReservation where Hall =" + hallnum + "";

            var Com = new SqlCommand(Sql, Conn);
            Com.Parameters.Add("@SeatNum", SqlDbType.NVarChar, 20);
            Com.Parameters["@SeatNum"].Value = this.label2.Text;
            int insertRowCnt = Com.ExecuteNonQuery();


            //다음창으로 이동
            예매선택확인 form6 = new 예매선택확인();
            form6.Passvalue = Passvalue;
			form6.SelectedSeatNum = txt1;
            form6.Show();
            this.Hide();
        }
        
        public void Seat(int[] empty)
        {
            Button[] Button = { btnA1, btnA2, btnA3, btnA4, btnA5,
                                btnB1, btnB2, btnB3, btnB4, btnB5,
                                btnC1, btnC2, btnC3, btnC4, btnC5,
                                btnD1, btnD2, btnD3, btnD4, btnD5};
            for (int i = 0; i < 20; i++)
            {
                if (empty[i] == 1)
                {
                    Button[i].BackColor = Color.White;
                    Button[i].ForeColor = Color.Black;
                }
            }
        }

		private void Form5_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
