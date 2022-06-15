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
    public partial class 관리자_재고관리창 : Form
    {
        bool reverse = true;
        private string Constr = "server=(local);database=MoogaBOx;" + "Integrated Security=true";
        public 관리자_재고관리창()
        {
            InitializeComponent();
        }

        //매점재고 출럭 
        private void PrintTable_Meajum()
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Com = new SqlCommand("SELECT * FROM Maejum", Conn);
            SqlDataReader R;
            R = Com.ExecuteReader();
            View_StoreStock.Items.Clear();
            ListViewItem item;
            while (R.Read())
            {
                item = new ListViewItem(R["SnackName"].ToString());
                item.SubItems.Add(R["SnackNum"].ToString());
                item.SubItems.Add(R["SnackCount"].ToString());
                View_StoreStock.Items.Add(item);
            }
            R.Close();
            Conn.Close();
        }

        //창고재고 출력 
        private void PrintTable_jaego()
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Com = new SqlCommand("SELECT * FROM Jaego", Conn);
            SqlDataReader R;
            R = Com.ExecuteReader();
            View_WearhouseStock.Items.Clear();
            ListViewItem item;
            while (R.Read())
            {
                item = new ListViewItem(R["SnackName"].ToString());
                item.SubItems.Add(R["SnackNum"].ToString());
                item.SubItems.Add(R["SnackCount"].ToString());
                View_WearhouseStock.Items.Add(item);
            }
            R.Close();
            Conn.Close();
        }

        //입고현황 출력
        private void PrintTable_Edong()
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Com = new SqlCommand("SELECT * FROM Edong", Conn);
            SqlDataReader R;
            R = Com.ExecuteReader();
            View_Order.Items.Clear();
            ListViewItem item;
            while (R.Read())
            {
                item = new ListViewItem(R["SnackName"].ToString());
                item.SubItems.Add(R["SnackNum"].ToString());
                item.SubItems.Add(R["SnackCount"].ToString());
                item.SubItems.Add(R["EdongNum"].ToString());
                View_Order.Items.Add(item);
            }
            R.Close();
            Conn.Close();
        }

        //뒤로가기 버튼 
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_재고메뉴선택창 M_frm3 = new 관리자_재고메뉴선택창();
            M_frm3.ShowDialog();
            Application.Exit();
        }

        //발주메뉴로 이동하는 버튼 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자_발주관리창 M_frm5 = new 관리자_발주관리창();
            M_frm5.ShowDialog();
            Application.Exit();
        }

        //폼 4로드시  각 테이블 출력과 view 옵션 설정 
        private void ManagerForm4_Load(object sender, EventArgs e)
        {
            View_StoreStock.GridLines = true;
            View_StoreStock.FullRowSelect = true;
            View_WearhouseStock.GridLines = true;
            View_WearhouseStock.FullRowSelect = true;
            View_Order.GridLines = true;
            View_Order.FullRowSelect = true;

            PrintTable_Meajum();
            PrintTable_jaego();
            PrintTable_Edong();
        }

        //입고번호 누를시 오름차순 내림차순 정렬 
        private void View_Order_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column.ToString().Equals("3"))
            {
                SqlConnection Conn = new SqlConnection(Constr);
                Conn.Open();

                SqlCommand Com = new SqlCommand("SELECT * FROM Edong ORDER BY EdongNum ASC", Conn);
                SqlCommand Com1 = new SqlCommand("SELECT * FROM Edong ORDER BY EdongNum DESC", Conn);
                SqlDataReader R;
                SqlDataReader R1;
                View_Order.Items.Clear();
                ListViewItem item;

                if (reverse)
                {
                    R = Com.ExecuteReader();
                    while (R.Read())
                    {
                        item = new ListViewItem(R["SnackName"].ToString());
                        item.SubItems.Add(R["SnackNum"].ToString());
                        item.SubItems.Add(R["SnackCount"].ToString());
                        item.SubItems.Add(R["EdongNum"].ToString());
                        View_Order.Items.Add(item);
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
                        item.SubItems.Add(R1["EdongNum"].ToString());
                        View_Order.Items.Add(item);
                    }
                    reverse = true ;
                    R1.Close();
                }
                Conn.Close();
            }
        }

        //매장재고에서 우클릭으로 생산 누를시 일어나는 작업 
        private void 생산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            ListViewItem lvi = View_StoreStock.SelectedItems[0];
            string input = Microsoft.VisualBasic.Interaction.InputBox($"생산하실 {lvi.Text}의 개수를 입력해주세요", "생산");

            string Find = lvi.SubItems[1].Text;
            var Sql = $"update Maejum set SnackCount = SnackCount + 1 * {input} WHERE SnackNum='" + Find + "'";

            //탄산수 관련 
            var Sql_Spark_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'SW01'";
            var Sql_Spark_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'SW01' ";
            var Sql_Spark_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'SW01' ";
            var myCom_Spark_COUNT = new SqlCommand(Sql_Spark_COUNT, Conn);
            var myCom_Sql_Spark_M = new SqlCommand(Sql_Spark_M, Conn);
            var myCom_Sql_Spark_L = new SqlCommand(Sql_Spark_L, Conn);
            var Spark = myCom_Spark_COUNT.ExecuteReader();
            if (Spark.Read()) { }
            string Spark_Name = Spark[0].ToString();
            int Spark_Count = Convert.ToInt32(Spark[1].ToString());
            Spark.Close();

            //콜라시럽 관련 
            var Sql_Co_Sy_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'CS01'";
            var Sql_Co_Sy_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'CS01' ";
            var Sql_Co_Sy_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'CS01' ";
            var myCom_Co_Sy_COUNT = new SqlCommand(Sql_Co_Sy_COUNT, Conn);
            var myCom_Sql_Co_Sy_M = new SqlCommand(Sql_Co_Sy_M, Conn);
            var myCom_Sql_Co_Sy_L = new SqlCommand(Sql_Co_Sy_L, Conn);
            var co_sy = myCom_Co_Sy_COUNT.ExecuteReader();
            if (co_sy.Read()) { }
            string co_sy_Name = co_sy[0].ToString();
            int co_sy_Count = Convert.ToInt32(co_sy[1].ToString());
            co_sy.Close();

            //스프라이트시럽 관련 
            var Sql_Sp_Sy_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'SS01'";
            var Sql_Sp_Sy_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'SS01' ";
            var Sql_Sp_Sy_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'SS01' ";
            var myCom_Sp_Sy_COUNT = new SqlCommand(Sql_Sp_Sy_COUNT, Conn);
            var myCom_Sql_Sp_Sy_M = new SqlCommand(Sql_Sp_Sy_M, Conn);
            var myCom_Sql_Sp_Sy_L = new SqlCommand(Sql_Sp_Sy_L, Conn);
            var Sp_Sy = myCom_Sp_Sy_COUNT.ExecuteReader();
            if (Sp_Sy.Read()) { }
            string Sp_Sy_Name = Sp_Sy[0].ToString();
            int Sp_Sy_Count = Convert.ToInt32(Sp_Sy[1].ToString());
            Sp_Sy.Close();

            //환타오렌지시럽 관련 
            var Sql_Fan_O_Sy_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'OS01'";
            var Sql_Fan_O_Sy_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'OS01' ";
            var Sql_Fan_O_Sy_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'OS01' ";
            var myCom_Fan_O_Sy_COUNT = new SqlCommand(Sql_Fan_O_Sy_COUNT, Conn);
            var myCom_Sql_Fan_O_Sy_M = new SqlCommand(Sql_Fan_O_Sy_M, Conn);
            var myCom_Sql_Fan_O_Sy_L = new SqlCommand(Sql_Fan_O_Sy_L, Conn);
            var Fan_O_Sy = myCom_Fan_O_Sy_COUNT.ExecuteReader();
            if (Fan_O_Sy.Read()) { }
            string Fan_O_Sy_Name = Fan_O_Sy[0].ToString();
            int Fan_O_Sy_Count = Convert.ToInt32(Fan_O_Sy[1].ToString());
            Fan_O_Sy.Close();

            //환타파인애플시럽 관련 
            var Sql_Fan_F_Sy_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'PS01'";
            var Sql_Fan_F_Sy_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'PS01' ";
            var Sql_Fan_F_Sy_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'PS01' ";
            var myCom_Fan_F_Sy_COUNT = new SqlCommand(Sql_Fan_F_Sy_COUNT, Conn);
            var myCom_Sql_Fan_F_Sy_M = new SqlCommand(Sql_Fan_F_Sy_M, Conn);
            var myCom_Sql_Fan_F_Sy_L = new SqlCommand(Sql_Fan_F_Sy_L, Conn);
            var Fan_F_Sy = myCom_Fan_F_Sy_COUNT.ExecuteReader();
            if (Fan_F_Sy.Read()) { }
            string Fan_F_Sy_Name = Fan_F_Sy[0].ToString();
            int Fan_F_Sy_Count = Convert.ToInt32(Fan_F_Sy[1].ToString());
            Fan_F_Sy.Close();

            //옥수수 관련 
            var Sql_CO_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'CO01'";
            var Sql_CO_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'CO01' ";
            var Sql_CO_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'CO01' ";
            var myCom_CO_COUNT = new SqlCommand(Sql_CO_COUNT, Conn);
            var myCom_CO_M = new SqlCommand(Sql_CO_M, Conn);
            var myCom_CO_L = new SqlCommand(Sql_CO_L, Conn);
            var CO = myCom_CO_COUNT.ExecuteReader();
            if (CO.Read()) { }
            string CO_Name = CO[0].ToString();
            int CO_Count = Convert.ToInt32(CO[1].ToString());
            CO.Close();

            //버터 관련 
            var Sql_BT_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'BT01'";
            var Sql_BT_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'BT01' ";
            var Sql_BT_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'BT01' ";
            var myCom_BT_COUNT = new SqlCommand(Sql_BT_COUNT, Conn);
            var myCom_BT_M = new SqlCommand(Sql_BT_M, Conn);
            var myCom_BT_L = new SqlCommand(Sql_BT_L, Conn);
            var BT = myCom_BT_COUNT.ExecuteReader();
            if (BT.Read()) { }
            string BT_Name = BT[0].ToString();
            int BT_Count = Convert.ToInt32(BT[1].ToString());
            BT.Close();

            //시즈닝(달콤) 관련  
            var Sql_SD_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'SD01'";
            var Sql_SD_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'SD01' ";
            var Sql_SD_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'SD01' ";
            var myCom_SD_COUNT = new SqlCommand(Sql_SD_COUNT, Conn);
            var myCom_SD_M = new SqlCommand(Sql_SD_M, Conn);
            var myCom_SD_L = new SqlCommand(Sql_SD_L, Conn);
            var SD = myCom_SD_COUNT.ExecuteReader();
            if (SD.Read()) { }
            string SD_Name = SD[0].ToString();
            int SD_Count = Convert.ToInt32(SD[1].ToString());
            SD.Close();

            //시즈닝(치즈) 관련  
            var Sql_SC_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'SC01'";
            var Sql_SC_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'SC01' ";
            var Sql_SC_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'SC01' ";
            var myCom_SC_COUNT = new SqlCommand(Sql_SC_COUNT, Conn);
            var myCom_SC_M = new SqlCommand(Sql_SC_M, Conn);
            var myCom_SC_L = new SqlCommand(Sql_SC_L, Conn);
            var SC = myCom_SC_COUNT.ExecuteReader();
            if (SC.Read()) { }
            string SC_Name = SC[0].ToString();
            int SC_Count = Convert.ToInt32(SC[1].ToString());
            SC.Close();

            //시즈닝(어니언) 관련  
            var Sql_SO_COUNT = "Select SnackName, SnackCount from jaego where SnackNum = 'SO01'";
            var Sql_SO_M = $"update jaego set SnackCount = SnackCount - 1 * {input} WHERE SnackNum= 'SO01' ";
            var Sql_SO_L = $"update jaego set SnackCount = SnackCount - 2 * {input} WHERE SnackNum= 'SO01' ";
            var myCom_SO_COUNT = new SqlCommand(Sql_SO_COUNT, Conn);
            var myCom_SO_M = new SqlCommand(Sql_SO_M, Conn);
            var myCom_SO_L = new SqlCommand(Sql_SO_L, Conn);
            var SO = myCom_SO_COUNT.ExecuteReader();
            if (SO.Read()) { }
            string SO_Name = SO[0].ToString();
            int SO_Count = Convert.ToInt32(SO[1].ToString());
            SO.Close();

            var myCom = new SqlCommand(Sql, Conn);
            관리자_팝콘생산애니매이션 Mfrm6 = new 관리자_팝콘생산애니매이션();
            관리자_콜라생산애니매이션 Mfrm7 = new 관리자_콜라생산애니매이션();

            //생산 
            //코카콜라(M)
            if (Find == "D01M")
            {
                // 콜라 시럽 재고 없을 경우
                if (co_sy_Count == 0)
                {
                    MessageBox.Show($"{co_sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 콜라 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) - co_sy_Count) > 0)
                {
                    MessageBox.Show($"{co_sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - co_sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else 
                {
                    myCom_Sql_Co_Sy_M.ExecuteNonQuery();
                    myCom_Sql_Spark_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //코카콜라(L)
            else if (Find == "D01L")
            {
                // 콜라 시럽 재고 없을 경우
                if (co_sy_Count == 0)
                {
                    MessageBox.Show($"{co_sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 콜라 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - co_sy_Count) > 0)
                {
                    MessageBox.Show($"{co_sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - co_sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2- Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_Sql_Co_Sy_L.ExecuteNonQuery();
                    myCom_Sql_Spark_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //스프라이트(M)
            else if (Find == "D02M")
            {
                // 스프라이트 시럽 재고 없을 경우
                if (Sp_Sy_Count == 0)
                {
                    MessageBox.Show($"{Sp_Sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 스프라이트 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) - Sp_Sy_Count) > 0)
                {
                    MessageBox.Show($"{Sp_Sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - Sp_Sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_Sql_Sp_Sy_M.ExecuteNonQuery();
                    myCom_Sql_Spark_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //스프라이트(L)
            else if (Find == "D02L")
            {
                // 스프라이트 시럽 재고 없을 경우
                if (Sp_Sy_Count == 0)
                {
                    MessageBox.Show($"{Sp_Sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 스프라이트 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - Sp_Sy_Count) > 0)
                {
                    MessageBox.Show($"{Sp_Sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - Sp_Sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_Sql_Sp_Sy_L.ExecuteNonQuery();
                    myCom_Sql_Spark_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //환타오렌지(M)
            else if (Find == "D03M")
            {
                // 환타오렌지 시럽 재고 없을 경우
                if (Fan_O_Sy_Count == 0)
                {
                    MessageBox.Show($"{Fan_O_Sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 환타오렌지 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) - Fan_O_Sy_Count) > 0)
                {
                    MessageBox.Show($"{Fan_O_Sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - Fan_O_Sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_Sql_Fan_O_Sy_M.ExecuteNonQuery();
                    myCom_Sql_Spark_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //환타오렌지(L)
            else if (Find == "D03L")
            {
                // 환타오렌지 시럽 재고 없을 경우
                if (Fan_O_Sy_Count == 0)
                {
                    MessageBox.Show($"{Fan_O_Sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 환타오렌지 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - Fan_O_Sy_Count) > 0)
                {
                    MessageBox.Show($"{Fan_O_Sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - Fan_O_Sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_Sql_Fan_O_Sy_L.ExecuteNonQuery();
                    myCom_Sql_Spark_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //환타파인애플(M)
            else if (Find == "D04M")
            {
                // 환타파인애플 시럽 재고 없을 경우
                if (Fan_F_Sy_Count == 0)
                {
                    MessageBox.Show($"{Fan_F_Sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 환타파인애플 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) - Fan_F_Sy_Count) > 0)
                {
                    MessageBox.Show($"{Fan_F_Sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - Fan_F_Sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_Sql_Fan_F_Sy_M.ExecuteNonQuery();
                    myCom_Sql_Spark_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //환타파인애플(L)
            else if (Find == "D04L")
            {
                // 환타파인애플 시럽 재고 없을 경우
                if (Fan_F_Sy_Count == 0)
                {
                    MessageBox.Show($"{Fan_F_Sy_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 환타파인애플 시럽이 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - Fan_F_Sy_Count) > 0)
                {
                    MessageBox.Show($"{Fan_F_Sy_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - Fan_F_Sy_Count)}개 모자라서 생산이 불가합니다.");
                }
                //탄산수 재고 없을 경우
                else if (Spark_Count == 0)
                {
                    MessageBox.Show($"{Spark_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 탄산수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - Spark_Count) > 0)
                {
                    MessageBox.Show($"{Spark_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - Spark_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_Sql_Fan_F_Sy_L.ExecuteNonQuery();
                    myCom_Sql_Spark_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm7.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //고소팝콘(M)
            else if (Find == "P01M")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_M.ExecuteNonQuery();
                    myCom_BT_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //고소팝콘(L)
            else if (Find == "P01L")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_L.ExecuteNonQuery();
                    myCom_BT_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //달콤팝콘(M)
            else if (Find == "P02M")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //시즈닝(달콤) 재고 없을 경우
                else if (SD_Count == 0)
                {
                    MessageBox.Show($"{SD_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 시즈닝(달콤) 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - SD_Count) > 0)
                {
                    MessageBox.Show($"{SD_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - SD_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_M.ExecuteNonQuery();
                    myCom_BT_M.ExecuteNonQuery();
                    myCom_SD_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //달콤팝콘(L)
            else if (Find == "P02L")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //시즈닝(달콤) 재고 없을 경우
                else if (SD_Count == 0)
                {
                    MessageBox.Show($"{SD_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 시즈닝(달콤) 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - SD_Count) > 0)
                {
                    MessageBox.Show($"{SD_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - SD_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_L.ExecuteNonQuery();
                    myCom_BT_L.ExecuteNonQuery();
                    myCom_SD_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //더블치즈팝콘(M)
            else if (Find == "P03M")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //시즈닝(치즈) 재고 없을 경우
                else if (SC_Count == 0)
                {
                    MessageBox.Show($"{SC_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 시즈닝(치즈) 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - SC_Count) > 0)
                {
                    MessageBox.Show($"{SC_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - SC_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_M.ExecuteNonQuery();
                    myCom_BT_M.ExecuteNonQuery();
                    myCom_SC_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //더블치즈팝콘(L)
            else if (Find == "P03L")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //시즈닝(달콤) 재고 없을 경우
                else if (SC_Count == 0)
                {
                    MessageBox.Show($"{SC_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 시즈닝(달콤) 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - SC_Count) > 0)
                {
                    MessageBox.Show($"{SC_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - SC_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_L.ExecuteNonQuery();
                    myCom_BT_L.ExecuteNonQuery();
                    myCom_SC_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //바질어니언팝콘(M)
            else if (Find == "P04M")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //시즈닝(치즈) 재고 없을 경우
                else if (SO_Count == 0)
                {
                    MessageBox.Show($"{SO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 시즈닝(치즈) 재고 부족할 경우 
                else if ((Convert.ToInt32(input) - SO_Count) > 0)
                {
                    MessageBox.Show($"{SO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) - SO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_M.ExecuteNonQuery();
                    myCom_BT_M.ExecuteNonQuery();
                    myCom_SO_M.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            //바질어니언팝콘(L)
            else if (Find == "P04L")
            {
                // 옥수수 재고 없을 경우
                if (CO_Count == 0)
                {
                    MessageBox.Show($"{CO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 옥수수 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - CO_Count) > 0)
                {
                    MessageBox.Show($"{CO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - CO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //버터 재고 없을 경우
                else if (BT_Count == 0)
                {
                    MessageBox.Show($"{BT_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 버터 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - BT_Count) > 0)
                {
                    MessageBox.Show($"{BT_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - BT_Count)}개 모자라서 생산이 불가합니다.");
                }
                //시즈닝(치즈) 재고 없을 경우
                else if (SO_Count == 0)
                {
                    MessageBox.Show($"{SO_Name}의 재고가 없어서 생산이 불가합니다.");
                }
                //생산 시 시즈닝(치즈) 재고 부족할 경우 
                else if ((Convert.ToInt32(input) * 2 - SO_Count) > 0)
                {
                    MessageBox.Show($"{SO_Name}의 개수가 {Math.Abs(Convert.ToInt32(input) * 2 - SO_Count)}개 모자라서 생산이 불가합니다.");
                }
                //생산
                else
                {
                    myCom_CO_L.ExecuteNonQuery();
                    myCom_BT_L.ExecuteNonQuery();
                    myCom_SO_L.ExecuteNonQuery();
                    myCom.ExecuteNonQuery();
                    Mfrm6.ShowDialog();
                    MessageBox.Show($"{lvi.Text}이(가) {input}개 생산되었습니다.");
                }
            }

            PrintTable_Meajum();
            PrintTable_jaego();
            Conn.Close();
        }

		private void ManagerForm4_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
