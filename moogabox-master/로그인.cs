using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;


namespace moogabox
{
    public partial class 로그인 : Form
    {
        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";

        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = "계정 (아이디 또는 이메일)";
        const string PwPlaceholder = "비밀번호";
        public 로그인()
        {
            InitializeComponent();


            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { txtId, txtPw };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txtId) txt.Text = IdPlaceholder;
                else if (txt == txtPw) txt.Text = PwPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == txtPw) txtPw.PasswordChar = '●';
            }
        }


        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == txtId) txt.Text = IdPlaceholder;
                else if (txt == txtPw) { txt.Text = PwPlaceholder; txtPw.PasswordChar = default; }
            }
        }
        private void Form0_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Comm = new SqlCommand("Select * from Member where ID = '" + this.txtId.Text + "'", Conn);
            SqlDataReader reader = Comm.ExecuteReader();
            if (reader.Read())
            {
                string strpwd = reader["PW"].ToString();
                int Who = Convert.ToInt32(reader["Who"].ToString());

                if (strpwd == this.txtPw.Text)
                {
                    reader.Close();
                    Conn.Close();

                    if (Who == 0)
                    {
                        메뉴선택 frm1 = new 메뉴선택();
						frm1.ID = this.txtId.Text;
                        frm1.Show();
                        this.Hide();
                    }

                    else if (Who == 1)
                    {
                        관리자_첫화면 MForm1 = new 관리자_첫화면();
                        MForm1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClear();
                }
            }
            else
            {
                MessageBox.Show("해당 사용자가 없습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClear();
            }
            reader.Close();
            Conn.Close();
        }

        private void txtClear()
        {
            this.txtId.Text = "";
            this.txtPw.Text = "";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            회원가입 frm10 = new 회원가입();
            DialogResult result = frm10.ShowDialog();
            if (result == DialogResult.Cancel || result == DialogResult.OK)
            {
                frm10.Close();
            }
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form0_Load(object sender, EventArgs e)
		{

		}

		private void Form0_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}