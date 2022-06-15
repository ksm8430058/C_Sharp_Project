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
	//SQL에서 시간불러와서 DateCompare함수 이용해서 구하기.
	//btnTime01.Enabled = false;
	public partial class 영화및시간선택 : Form
	{
		public string ID { get; set; }
		private SqlConnection Con;
		public 영화및시간선택()
		{
			InitializeComponent();
		}

		private string Constr = "Server=(local);database=MoogaBox;" +
		"Integrated Security=true";

		private void Form4_Load(object sender, EventArgs e)
		{
			if (ID == null) ID = "1";
			string Nowtime = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분");
			lblTime.Text = Nowtime;

			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=MoogaBox;" +
				"Integrated Security=true";
			Con.Open();

			var Comm01 = new SqlCommand("select starttime from Movie", Con);
			var myRead01 = Comm01.ExecuteReader();

			int i = 0;

			string[] time = new string[19];

			while (myRead01.Read())
			{
				time[i] = myRead01[0].ToString();
				i++;
			}

			Button[] button = {btnTime07, btnTime08, btnTime09, btnTime010, btnTime11,
							btnTime12, btnTime01, btnTime02, btnTime03, btnTime04,
							btnTime05, btnTime06, btnTime13, btnTime15, btnTime16,
							btnTime17, btnTime18, btnTime19, btnTime20};

			for (int j = 0; j < 19; j++)
			{
				if (!Btn_enabled(time[j]))
				{
					button[j].Enabled = false;
				}
			}
			
			myRead01.Close();

		}

		private void Form4_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Con.State == ConnectionState.Open)
			{
				Con.Close();
			}
		}
		// 범죄도시 2
		private void btnTime01_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='CC01'", Con);
			var myRead01 = Comm01.ExecuteReader();

			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie1.Image;
				/*                Date2 = myRead01[2].ToString();

								DateTime t2 = DateTime.Parse(Date2);

								int result = DateTime.Compare(DateTime.Now, t2);

								MessageBox.Show(result.ToString());*/
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime,MvNum) select MvName,Hall,StartTime from Movie where MvNum='CC01' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;

		}

		private void btnTime02_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='CC02'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie1.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='CC02' ");
			var Com = new SqlCommand(InsertSql, Con);


			groupBox1.Visible = true;

		}

		private void btnTime03_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='CC03'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString(); ;
				pbMovie.Image = pbMovie1.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='CC03' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;

		}

		private void btnTime04_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='CC04'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie1.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='CC04' ");
			var Com = new SqlCommand(InsertSql, Con);


			groupBox1.Visible = true;
		}

		private void btnTime05_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='CC05'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie1.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='CC05' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime06_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='CC06'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie1.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='CC06' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}
		private void btnTime13_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='CC07'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie2.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='CC07' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		//닥터스트레인지
		private void btnTime07_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='DR01'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie2.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='DR01' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime08_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='DR02'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie2.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='DR02' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime09_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='DR03'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie2.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='DR03' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime010_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='DR04'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie2.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='DR04' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime11_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='DR05'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie2.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='DR05' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime12_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='DR06'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie2.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='DR06' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		//쥬라기월드 -도미니언
		private void btnTime15_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='JW01'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie3.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='JW01' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;

		}

		private void btnTime16_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='JW02'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie3.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='JW02' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime17_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='JW03'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie3.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='JW03' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime18_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='JW04'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie3.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='JW04' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime19_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='JW05'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie3.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='JW05' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}

		private void btnTime20_Click(object sender, EventArgs e)
		{
			var Comm01 = new SqlCommand("select * from Movie where MvNum='JW06'", Con);
			var myRead01 = Comm01.ExecuteReader();
			if (myRead01.Read())
			{
				this.name.Text = myRead01[0].ToString();
				this.time.Text = myRead01[2].ToString();
				this.lblhall1.Text = myRead01[1].ToString();
				this.mvnum.Text = myRead01[4].ToString();
				pbMovie.Image = pbMovie3.Image;
			}
			myRead01.Close();

			string InsertSql = string.Format("insert into TmpReservation(MvName, Hall,StartTime) select MvName,Hall,StartTime from Movie where MvNum='JW06' ");
			var Com = new SqlCommand(InsertSql, Con);

			groupBox1.Visible = true;
		}



		private void bntOK_Click(object sender, EventArgs e)
		{
			//지정한 영화이름과 영화품번, 시간이 TmpReservation으로 들어간다

			var Conn = new SqlConnection(Constr);
			Conn.Open();

			string Sql = "insert into TmpReservation(ID, MvName,Hall,StartTime) "
								+ "values(@ID, @MvName,@Hall, @StartTime)";

			var Comm = new SqlCommand(Sql, Conn);

			Comm.Parameters.Add("@ID", SqlDbType.VarChar, 10);
			Comm.Parameters.Add("@MvName", SqlDbType.NVarChar, 20);
			Comm.Parameters.Add("@Hall", SqlDbType.Int);
			Comm.Parameters.Add("@StartTime", SqlDbType.Time, 7);

			Comm.Parameters["@ID"].Value = ID;
			Comm.Parameters["@MvName"].Value = this.name.Text;
			Comm.Parameters["@Hall"].Value = Convert.ToInt32(this.lblhall1.Text);
			Comm.Parameters["@StartTime"].Value = this.time.Text;

			int insertRowCnt = Comm.ExecuteNonQuery();

			//좌석창으로 이동
			영화좌석선택 form5 = new 영화좌석선택();
			form5.Passvalue = this.mvnum.Text;
			form5.ID = this.ID;
			form5.Show();
			this.Hide();

		}

		private bool Btn_enabled(string Time)
		{

			TimeSpan diff = DateTime.Now - Convert.ToDateTime(Time);

			if (diff.Hours >= 0 && diff.Minutes >= 0)
			{
				return false;
			}

			else return true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//첫 창으로 이동
			var Comm = new SqlCommand("delete from TmpReservation", Con);
			Comm.ExecuteNonQuery();

			Con.Close();

			메뉴선택 form1 = new 메뉴선택();
			form1.Show();
			this.Hide();
		}

		private void Form4_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}