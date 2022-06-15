using System;
using System.Collections;
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
    public partial class 관리자_발주관리창 : Form
    {
        private SqlConnection Con;
        bool reverse = true;
        private string Constr = "server=(local);database=MoogaBox;" + "Integrated Security=true";

        public 관리자_발주관리창()
        {
            InitializeComponent();
        }

        //창고재고 출력 
        private void PrintTable_jaego()
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Com = new SqlCommand("SELECT * FROM Jaego", Conn);
            SqlDataReader R;
            R = Com.ExecuteReader();
            listView1.Items.Clear();
            ListViewItem item;
            while (R.Read())
            {
                item = new ListViewItem(R["SnackName"].ToString());
                item.SubItems.Add(R["SnackNum"].ToString());
                item.SubItems.Add(R["SnackCount"].ToString());
                listView1.Items.Add(item);
            }
            R.Close();
            Conn.Close();
        }

        //발주목록 출력 
        private void PrintTable_Balju()
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Com = new SqlCommand("SELECT * FROM Balju", Conn);
            SqlDataReader R;
            R = Com.ExecuteReader();
            listView2.Items.Clear();
            ListViewItem item;
            while (R.Read())
            {
                item = new ListViewItem(R["SnackName"].ToString());
                item.SubItems.Add(R["SnackNum"].ToString());
                item.SubItems.Add(R["SnackCount"].ToString());
                item.SubItems.Add(R["BalNum"].ToString());
                listView2.Items.Add(item);
            }
            R.Close();
            Conn.Close();
        }

        //뒤로가기 누를시 폼3으로 이동 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_재고메뉴선택창 M_frm3 = new 관리자_재고메뉴선택창();
            M_frm3.ShowDialog();
            Application.Exit();
        }

        //폼5 로드 될시 각 테이블 출력과 view 옵션설정
        private void ManagerForm5_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = "server=(local);database=MoogaBox;" + "Integrated Security=true";
            Con.Open();
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            PrintTable_jaego();
            PrintTable_Balju();
        }

        //발주리스트에서 우클릭으로 창고 입고 누를시 창고재고에 입고됨 
        private void 창고입고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView2.SelectedItems[0];
            string Find = lvi.Text;
            string input = lvi.SubItems[2].Text;
            string Sql_I = string.Format("insert into  Edong values ('{0}', '{1}', {2})", lvi.Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text);
            string Sql_D = "DELETE Balju WHERE SnackName ='" + Find + "'";
            var Sql = $"update Jaego set SnackCount = SnackCount + {input} WHERE SnackName='" + Find + "'";

            var myCom_I = new SqlCommand(Sql_I, Con);
            var myCom_D = new SqlCommand(Sql_D, Con);
            var myCom = new SqlCommand(Sql, Con);
            myCom_I.ExecuteNonQuery();
            myCom_D.ExecuteNonQuery();
            myCom.ExecuteNonQuery();
            PrintTable_jaego();
            PrintTable_Balju();
        }

        //발주리스트에서 우클릭으로 발주 누르고 필요 수량 누르면 입고 됨
        private void 발주ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //참조로 Microsoft visualBasic 가져옴
                ListViewItem lvi = listView1.SelectedItems[0];
                string input = Microsoft.VisualBasic.Interaction.InputBox($"발주하실 {lvi.Text}의 개수를 입력해주세요", "발주");
                string Sql = string.Format("insert into  Balju values ('{0}', '{1}', {2})", lvi.Text, lvi.SubItems[1].Text, input);
                SqlCommand Com = new SqlCommand(Sql, Con);
                Com.ExecuteNonQuery();
                PrintTable_Balju();
            }
        }

        //발주번호 클릭시 오름차순 내림차순으로 정렬
        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column.ToString().Equals("3"))
            {
                SqlConnection Conn = new SqlConnection(Constr);
                Conn.Open();

                SqlCommand Com = new SqlCommand("SELECT * FROM Balju ORDER BY BalNum ASC", Conn);
                SqlCommand Com1 = new SqlCommand("SELECT * FROM Balju ORDER BY BalNum DESC", Conn);
                SqlDataReader R;
                SqlDataReader R1;
                listView2.Items.Clear();
                ListViewItem item;

                if (reverse)
                {
                    R = Com.ExecuteReader();
                    while (R.Read())
                    {
                        item = new ListViewItem(R["SnackName"].ToString());
                        item.SubItems.Add(R["SnackNum"].ToString());
                        item.SubItems.Add(R["SnackCount"].ToString());
                        item.SubItems.Add(R["BalNum"].ToString());
                        listView2.Items.Add(item);
                    }
                    reverse = false;
                    R.Close();
                }
                else
                {
                    R1 = Com1.ExecuteReader();
                    while (R1.Read())
                    {
                        item = new ListViewItem(R1["SnackName"].ToString());
                        item.SubItems.Add(R1["SnackNum"].ToString());
                        item.SubItems.Add(R1["SnackCount"].ToString());
                        item.SubItems.Add(R1["BalNum"].ToString());
                        listView2.Items.Add(item);
                    }
                    reverse = true;
                    R1.Close();
                }
                Conn.Close();
            }
        }

		private void ManagerForm5_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
