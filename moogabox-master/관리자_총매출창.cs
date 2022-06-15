using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using Cinema_Kiosk_SalesManager;

namespace moogabox
{
    public partial class 관리자_총매출창 : Form
    {
        //  SQL 연결문자열  //  Server=(local)은 연결되는 서버주소마다 봐낌
        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";

        public 관리자_총매출창()
        {
            InitializeComponent();
        }

        private void ManagerForm2_Load(object sender, EventArgs e)  //  ManagerForm2 화면이 실행될떄
        {
            TodaySalesList();  //  오늘 판매된 목록 리스트 __ 총 판매금액
        }

        private void TodaySalesList()  //  오늘 판매된 목록 리스트
        {
            //  SQL Server 서버연결
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            // View_TotalSale의 항목을 가져온 다음 초기화( 제거 ) 진행
            View_TotalSale.Items.Clear();

            // SQL 테이블로 부터 데이터를 가져온다
            SqlCommand command = new SqlCommand("USE MoogaBox SELECT SnackName ,SnackNum, BuyPrice, BuyCount FROM BuySnack", Conn);  //  스낵구매
            SqlCommand command1 = new SqlCommand("USE MoogaBox SELECT MvName, Mmoney, Ccount, RsvCode FROM Reservation", Conn);      //  영화예매

            // SQL Server와 연결을 유지한 상태에서 한번에 한 레코드씩 데이터를 가져온다
            SqlDataReader reader = command.ExecuteReader();
            
            //  총합계 초기화
            int sum = 0;

            // SQL Server에서 반복하여 데이터를 불러온다  //  BuySnack 테이블
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["SnackName"].ToString());  //  Snack Name
                item.SubItems.Add(reader["BuyPrice"].ToString());                      //  Snack Price
                item.SubItems.Add(reader["BuyCount"].ToString());                      //  Snack Count
                item.SubItems.Add(reader["SnackNum"].ToString());                      //  Snack Num

                View_TotalSale.Items.Add(item);  //  View_TotalSale  데이터 추가 후 보여준다

                //  SUM = 음식의 가격과 개수를 연산한 값을 SUM 에 인트형식으로 한개씩 더하며 저장한다
                sum += Convert.ToInt32(reader["BuyPrice"]) * Convert.ToInt32(reader["BuyCount"]);
            }

            // 연결된 SQL Server를 닫는다  //  BuySnack 테이블
            reader.Close();

            // SQL Server와 연결을 유지한 상태에서 한번에 한 레코드씩 데이터를 가져온다
            SqlDataReader reader1 = command1.ExecuteReader();

            // SQL Server에서 반복하여 데이터를 불러온다  //  Reservation 테이블 
            while (reader1.Read())
            {
                ListViewItem item1 = new ListViewItem(reader1["MvName"].ToString());    //  Movie Name
                item1.SubItems.Add(reader1["Mmoney"].ToString());                       //  Movie Money
                item1.SubItems.Add(reader1["Ccount"].ToString());                       //  Movie Count
                item1.SubItems.Add(reader1["RsvCode"].ToString());                      //  Moive RsvCode

                View_TotalSale.Items.Add(item1);  //  View_TotalSale  데이터 추가

                //  SUM = 저장된 음식의 값과 영화예매 금액을 인트형식으로 한개씩 더하며 자장한다.
                sum += Convert.ToInt32(reader1["Mmoney"]);

                //=============================================================================//
                //            영화 예매 테이블에서 Mmoney가 총금액이라는 가정하에              //
                //            작성하였고 만약 총금액이 아니라면 코드를 수정해야함              //
                // EX) Convert.ToInt32(reader1["Mmoney"]) * convert.ToInt32(reader1["Ccount"]);//
                //=============================================================================//
            }

            textTotal.Text = sum.ToString();      //  입력 받은 SUM 데이터를 문자열로  TextBox에 보여준다
                                                  //  TextBox는 ReadOnly True로 입력/수정 X

            View_TotalSale.GridLines = true;      //  View_TotalSale 의 저장된 각 데이터 사이에 선을 만듬 
            View_TotalSale.FullRowSelect = true;  //  View_TotalSale 안의 데이터당 한줄 전부 선택됨

            // 연결된 SQL Server를 닫는다  //  Reservation 테이블 
            reader1.Close();
        }


        //=======================================================================================================================//
        //=============================================== ListView  설정 ========================================================//
        //=======================================================================================================================//


        //  ListView  Header 컬럼의 사이즈를 임의로 조정하지 못하게 하는 이벤트  //
        private void View_TotalSale_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = View_TotalSale.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }


        //  ListView  Header 클릭시 오름차순 / 내림차순 정렬  //

        ColumnSorter columnsorter = new ColumnSorter();

        private int flag = 0;

        //리스트뷰에서 컬럼 헤더를 클릭시 소트 기능 구현
        private void View_TotalSale_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            columnsorter.currentColumn = e.Column;

            // 전에 선택했던 컬럼과 다르면 오름 차순 정렬
            if (columnsorter.previousColumn != columnsorter.currentColumn)
            {
                columnsorter.sort = Sorting.Ascending;
            }
            else    // 전에 선택했던 컬럼과 같을때
            {
                switch (columnsorter.sort)
                {
                    case Sorting.Ascending:// 오름차순이였다면 내림 차순으로 바꾼다.
                        columnsorter.sort = Sorting.Descending;
                        break;
                    case Sorting.Descending:
                        columnsorter.sort = Sorting.Ascending;
                        break;
                }
            }

            if (flag == 0)
            {
                View_TotalSale.ListViewItemSorter = (System.Collections.IComparer)columnsorter; // 자동으로 listvHeader.Sort()함수가 수행된다.
                flag = 1;
            }
            else
            {
                View_TotalSale.Sort();
            }

            // 현재 선택했던 컬럼을 기억해 둔다.
            columnsorter.previousColumn = columnsorter.currentColumn;
            return;
        }

        public enum Sorting { Ascending, Descending };

        //ListView에서 컬럼을 누르면 정렬이 되게 하기 위해
        public class ColumnSorter : IComparer
        {
            public int currentColumn = -1;   // 현재 선택한 컬럼
            public int previousColumn = -1;  // 전에 선책한 컬럼     
            public Sorting sort = Sorting.Ascending;

            public int Compare(object x, object y)
            {
                ListViewItem rowA = (ListViewItem)x;
                ListViewItem rowB = (ListViewItem)y;
                int result = 0;
                switch (sort)
                {
                    case Sorting.Ascending:     // 오름차 정렬을 원할때
                        result = String.Compare(rowA.SubItems[currentColumn].Text, rowB.SubItems[currentColumn].Text);
                        break;
                    case Sorting.Descending:    // 내림차순 정렬을 원할때
                        result = String.Compare(rowB.SubItems[currentColumn].Text, rowA.SubItems[currentColumn].Text);
                        break;
                }
                return result;
            }

            public ColumnSorter() { }
        }

        //=======================================================================================================================//
        //=======================================================================================================================//
        //=======================================================================================================================//



        //=======================================================================================================================//
        //=============================================    버튼 조작 정리     ===================================================//
        //=======================================================================================================================//

        private void Btn_Cancle_Click(object sender, EventArgs e)  // 취소 버튼 클릭시 이전화면으로 이동
        {
            this.Visible = false;
            관리자_첫화면 M_frm1 = new 관리자_첫화면();
            M_frm1.ShowDialog();
        }

        private void btnSG_Click(object sender, EventArgs e)  //  스낵의 판매량 그래프로 이동
        {
            SnackGraph newSnackGraph = new SnackGraph();
            newSnackGraph.ShowDialog();
        }

        private void btnMG_Click(object sender, EventArgs e)  //  영화티켓 판매량 그래프로 이동
        {
            MovieTicketGraph newMovieTicketGraph = new MovieTicketGraph();
            newMovieTicketGraph.ShowDialog();
        }

		private void ManagerForm2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		//=======================================================================================================================//
		//=======================================================================================================================//
		//=======================================================================================================================//

	}
}
