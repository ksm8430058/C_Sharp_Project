using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using moogabox;

namespace Cinema_Kiosk_SalesManager
{
    public partial class SnackGraph : Form
    {
        //  SQL 연결문자열  //  Server=(local)은 연결되는 서버주소마다 봐낌
        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";

        public SnackGraph()
        {
            InitializeComponent();
        }

        private void SnackGraph_Load(object sender, EventArgs e)
        {
            FillChart();  //  Form 이 실행될때 FillChart을 바로 보여준다
        }

        private void FillChart()  //  Chart에 SQL Server에서 불러온 BuySnack 데이터를 그래프로 보여준다
        {
            SqlConnection con = new SqlConnection(Constr);
            DataSet ds = new DataSet();
            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter("USE MoogaBox SELECT SnackName ,BuyPrice, BuyCount FROM BuySnack", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Count"].XValueMember = "SnackName";
            chart1.Series["Count"].YValueMembers = "BuyCount";
            chart1.Series["Money"].YValueMembers = "BuyPrice";
            con.Close();
        }

        private void btxExit_Click(object sender, EventArgs e)               //  취소버튼
        {
			관리자_총매출창 M_frm2 = new 관리자_총매출창();
			M_frm2.ShowDialog();
		}

		private void SnackGraph_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
