using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace moogabox
{
    public partial class 회원가입 : Form
    {
        public int Who { get; set; }
        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";

        public 회원가입()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);

            try
            {
                Conn.Open();

                string Sql = "INSERT INTO MEMBER(ID, PW, Phone, Who)" + "VALUES( @ID, @PW, @Phone, @Who)" ;
                var Comm = new SqlCommand(Sql, Conn);

                Comm.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                Comm.Parameters.Add("@Pw", SqlDbType.VarChar, 20);
                Comm.Parameters.Add("@Phone", SqlDbType.VarChar, 20);
                Comm.Parameters.Add("@Who", SqlDbType.Int);

                Comm.Parameters["@ID"].Value = this.txtID.Text;
                Comm.Parameters["@Pw"].Value = this.txtPW.Text;
                Comm.Parameters["@Phone"].Value = this.txtPhone.Text;

                if (rbNormal.Checked)
                {
                    Comm.Parameters["@Who"].Value = 0;
                }

                else if (rbManager.Checked)
                {
                    Comm.Parameters["@Who"].Value = 1;
                }

                if (DataChk())
                {
                    try
                    {
                        int insertRowCnt = Comm.ExecuteNonQuery();
                        Conn.Close();

                        if (insertRowCnt == 1)
                        {
                            MessageBox.Show("회원가입이 정상적으로 처리되었습니다.", "회원가입 성공",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                        }

                        else
                        {
                            MessageBox.Show("회원가입이 실패하였습니다.", "회원가입 실패",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("중복되는 ID입니다", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtClear();
                        this.ActiveControl = txtID;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("프로그램 실행 중 문제가 발생하였습니다.\n\n" + ex.Message , "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
            }
        }

        private void TxtClear()
        {
            txtID.Clear();
            txtPW.Clear();
            txtPhone.Clear();
        }

        private bool DataChk()
        {
            if (this.txtID.Text != "" && this.txtPW.Text != "" && this.txtPhone.Text != ""
                && (rbManager.Checked || rbNormal.Checked))
            {
                return true;  
            }                
            else
            {
                MessageBox.Show("입력 항목의 데이터를 확인해주세요.", "입력 항목 체크",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtID;
            pbMooga1.Load(@"..\..\Resources\moogabox.png");
            pbMooga1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

		private void Form10_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
	}
}
