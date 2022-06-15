using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace moogabox
{
    public partial class 예매조회 : Form
    {
        public string Reservation_Num { get; set; }
        public string Phone_num { get; set; }

        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";

        public 예매조회()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Next_Click(object sender, System.EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Comm = new SqlCommand("Select * from Reservation where RsvCode = '" + txtNum.Text + "'", Conn);

            SqlDataReader reader = Comm.ExecuteReader();
            if (reader.Read())
            {
                Reservation_Num = txtNum.Text;

                Form3 frm3 = new Form3();
                frm3.Reservation_Num = Reservation_Num;
                //DialogResult result = frm3.ShowDialog();
                //if(result == DialogResult.OK)
                //{
                this.Visible = false;
                frm3.ShowDialog();
                Application.Exit();
               // }
            }
            else
            {
                MessageBox.Show("예매번호가 존재하지 않습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            Conn.Close();

        }

        private void btnNext0_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Comm = new SqlCommand("Select * from Member where Phone = '" + txtPhone.Text + "'", Conn);
            SqlDataReader reader = Comm.ExecuteReader();

            if (reader.Read())
            {
                Phone_num = txtPhone.Text;

                예매조회결과 frm11 = new 예매조회결과();
                frm11.Phone_Num = Phone_num;

                //DialogResult result = frm11.ShowDialog();

                //if (result == DialogResult.OK)
                //{
					this.Visible = false;
					frm11.ShowDialog();
                    Application.Exit();
               //}
            }

            else
            {
                MessageBox.Show("전화번호가 존재하지 않습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            Conn.Close();
        }

		private void Form2_Load(object sender, EventArgs e)
		{

		}

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
