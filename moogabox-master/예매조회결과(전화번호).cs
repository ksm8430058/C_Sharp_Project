using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace moogabox
{
    public partial class 예매조회결과 : Form
    {

        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";

        public string Phone_Num { get; set; }

        public 예매조회결과()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();

            SqlConnection Conn = new SqlConnection(Constr);

            try
            {
                Conn.Open();

                var Comm = new SqlCommand("Select RsvCode, MvName, Hall, SeatNum, StartTime " +
                    "FROM Reservation R INNER JOIN Member M ON R.ID = M.ID WHERE M.Phone = '" + Phone_Num + "'", Conn);

                var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);

                while (myRead.Read())
                {
                    var ListArray = new String[] {myRead["Rsvcode"].ToString(),
                        myRead["MvName"].ToString(),
                        myRead["Hall"].ToString(),
                        myRead["SeatNum"].ToString(),
                        myRead["StartTime"].ToString()};

                    var lvt = new ListViewItem(ListArray);

                    this.listView1.Items.Add(lvt);
                }

                myRead.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 에러가 발생. \n" + ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
            }

           
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if(this.listView1.SelectedItems.Count > 0)
            {
                this.txtRvcode.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
                this.txtMvName.Text = this.listView1.SelectedItems[0].SubItems[1].Text;
                this.txtHall.Text = this.listView1.SelectedItems[0].SubItems[2].Text;
                this.txtSeat.Text = this.listView1.SelectedItems[0].SubItems[3].Text;
                this.txtTime.Text = this.listView1.SelectedItems[0].SubItems[4].Text;

                if (txtMvName.Text == "닥터 스트레인지")
                {
                    pbPoster.Load(@"..\..\Resources\닥터 스트레인지.png");
                    pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                else if (txtMvName.Text == "범죄도시2")
                {
                    pbPoster.Load(@"..\..\Resources\범죄도시2.png");
                    pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                else if (txtMvName.Text == "쥬라기 월드: 도미니언")
                {
                    pbPoster.Load(@"..\..\Resources\쥬라기월드new.png");
                    pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (DateChk())
            {
                string txt = "";

                char a = '\n';

                string[] txt1 = this.txtSeat.Text.Split(a);

                for (int i = 0; i < txt1.Length; i++)
                {
                    txt += txt1[i] + " ";
                }

                DialogResult OKonly =
                MessageBox.Show("영화 : " + this.txtMvName.Text + "\n\n시간 : " + this.txtTime.Text + "\n\n상영관 : " + txtHall.Text +
                    "\n\n좌석 : " + txt + "\n\n 발권되었습니다.", "발권 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (OKonly == DialogResult.OK)
                {
                    this.Visible = false;
                    메뉴선택 frm1 = new 메뉴선택();
                    예매조회 frm2 = new 예매조회();
                    frm2.Close();
                    frm1.ShowDialog();
                    Application.Exit();
                }
            }
		}

        private bool DateChk()
        {
            if (this.txtMvName.Text != "" && this.txtTime.Text != "" &&
                this.txtHall.Text != "" && this.txtSeat.Text != "" && this.txtMvName.Text != "")
                return true;
            else
            {
                MessageBox.Show("입력 항목의 데이터를 확인해주세요.", "입력 항목 체크",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

        }

    }
}
