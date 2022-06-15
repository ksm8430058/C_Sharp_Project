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
using moogabox.UserControls;

namespace moogabox
{
    public partial class 매점구매창 : Form
    {
        StoreOrder ord = new StoreOrder();

        private string connectionStr = "Server=(local);database=Moogabox;" +
                "Integrated Security=true";

        public 매점구매창()
        {
            InitializeComponent();

            UC_Popcorn up = new UC_Popcorn();
            addUserControl(up);

            up.Button1_Evnet += Popcorn1_Click_Event;
            up.Button2_Evnet += Popcorn2_Click_Event;
            up.Button3_Evnet += Popcorn3_Click_Event;
            up.Button4_Evnet += Popcorn4_Click_Event;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void tabPopcorn_Click(object sender, EventArgs e)
        {
            UC_Popcorn up = new UC_Popcorn();
            addUserControl(up);

            up.Button1_Evnet += Popcorn1_Click_Event;
            up.Button2_Evnet += Popcorn2_Click_Event;
            up.Button3_Evnet += Popcorn3_Click_Event;
            up.Button4_Evnet += Popcorn4_Click_Event;
        }

        private void tapDrink_Click(object sender, EventArgs e)
        {
            UC_Drink ud = new UC_Drink();
            addUserControl(ud);

            ud.Button1_Evnet += Drink1_Click_Event;
            ud.Button2_Evnet += Drink2_Click_Event;
            ud.Button3_Evnet += Drink3_Click_Event;
            ud.Button4_Evnet += Drink4_Click_Event;
        }

        private void tapSet_Click(object sender, EventArgs e)
        {
            UC_Set us = new UC_Set();
            addUserControl(us);

            us.Button1_Evnet += Set1_Click_Event;
            us.Button2_Evnet += Set2_Click_Event;
            us.Button3_Evnet += Set3_Click_Event;
            us.Button4_Evnet += Set4_Click_Event;
        }

        public void Popcorn1_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                // 리스트뷰에 상품이 이미 있는 경우 수량과 금액 추가함
                if (ord.popcorn1Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtPopcorn1.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtPopcorn1.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnPopcorn1.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.popcorn1Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.popcorn1Sum());
                            ord.popcorn1Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                // 리스트 뷰에 상품이 없는 경우 추가함
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtPopcorn1.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.popcorn1Cnt), Convert.ToString(ord.popcorn1Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.popcorn1Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Popcorn2_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.popcorn2Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtPopcorn2.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtPopcorn2.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnPopcorn2.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.popcorn2Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.popcorn2Sum());
                            ord.popcorn2Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtPopcorn2.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.popcorn2Cnt), Convert.ToString(ord.popcorn2Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.popcorn2Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Popcorn3_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.popcorn3Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtPopcorn3.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtPopcorn3.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnPopcorn3.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.popcorn3Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.popcorn3Sum());
                            ord.popcorn3Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtPopcorn3.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.popcorn3Cnt), Convert.ToString(ord.popcorn3Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.popcorn3Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Popcorn4_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.popcorn4Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtPopcorn4.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtPopcorn4.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnPopcorn4.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.popcorn4Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.popcorn4Sum());
                            ord.popcorn4Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtPopcorn4.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.popcorn4Cnt), Convert.ToString(ord.popcorn4Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.popcorn4Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Drink1_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.drink1Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtDrink1.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtDrink1.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnDrink1.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.drink1Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.drink1Sum());
                            ord.drink1Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtDrink1.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var drink = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.drink1Cnt), Convert.ToString(ord.drink1Sum()) };
                        var lvt = new ListViewItem(drink);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.drink1Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Drink2_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.drink2Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtDrink2.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtDrink2.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnDrink2.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.drink2Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.drink2Sum());
                            ord.drink2Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtDrink2.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var drink = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.drink2Cnt), Convert.ToString(ord.drink2Sum()) };
                        var lvt = new ListViewItem(drink);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.drink2Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Drink3_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.drink3Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtDrink3.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtDrink3.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnDrink3.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.drink3Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.drink3Sum());
                            ord.drink3Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtDrink3.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var drink = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.drink3Cnt), Convert.ToString(ord.drink3Sum()) };
                        var lvt = new ListViewItem(drink);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.drink3Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Drink4_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.drink4Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtDrink4.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtDrink4.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnDrink4.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.drink4Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.drink4Sum());
                            ord.drink4Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtDrink4.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var drink = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.drink4Cnt), Convert.ToString(ord.drink4Sum()) };
                        var lvt = new ListViewItem(drink);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.drink4Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Set1_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.set1Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtSet1.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtSet1.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnSet1.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.set1Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.set1Sum());
                            ord.set1Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtSet1.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.set1Cnt), Convert.ToString(ord.set1Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.set1Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Set2_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.set2Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtSet2.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtSet2.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnSet2.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.set2Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.set2Sum());
                            ord.set2Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtSet2.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.set2Cnt), Convert.ToString(ord.set2Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.set2Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //데이터 베이스 접속을 종료함.
                Conn.Close();
            }
        }

        public void Set3_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.set3Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtSet3.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtSet3.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnSet3.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.set3Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.set3Sum());
                            ord.set3Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtSet3.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.set3Cnt), Convert.ToString(ord.set3Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.set3Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Conn.Close();
            }
        }

        public void Set4_Click_Event(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;

            try
            {
                Conn.Open();
                string SQL = "SELECT SnackNum ,SnackName, SnackPrice FROM Snack WHERE SnackNum = @SnackNum";
                var Comm = new SqlCommand(SQL, Conn);

                if (ord.set4Cnt >= 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (listTotal.Items[i].SubItems[0].Text == txtSet4.Text)
                        {
                            listTotal.Items[i].Focused = true;
                            listTotal.Items[i].Selected = true;
                            listTotal.FocusedItem.SubItems[0].Text = txtSet4.Text;
                            listTotal.FocusedItem.SubItems[1].Text = btnSet4.Text;
                            listTotal.FocusedItem.SubItems[3].Text = Convert.ToString(ord.set4Cnt);
                            listTotal.FocusedItem.SubItems[4].Text = Convert.ToString(ord.set4Sum());
                            ord.set4Cnt++;
                            listTotal.Items[i].Selected = false;
                        }
                    }
                }
                else
                {
                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters["@SnackNum"].Value = this.txtSet4.Text;

                    var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);
                    while (myRead.Read())
                    {
                        var popcorn = new string[] { myRead["SnackNum"].ToString(), myRead["SnackName"].ToString(), myRead["SnackPrice"].ToString(), Convert.ToString(ord.set4Cnt), Convert.ToString(ord.set4Sum()) };
                        var lvt = new ListViewItem(popcorn);
                        this.listTotal.Items.Add(lvt);
                        listTotal.Focus();
                        ord.set4Cnt++;
                    }
                    myRead.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Conn.Close();
            }
        }

        // 취소 버튼을 누를시 리스트 뷰에 상품삭제 (위에서 부터 삭제됨)
        private void btnSelCancel_Click(object sender, EventArgs e)
        {
            int count = listTotal.Items.Count;
            // 리스트뷰에 상품이 없는 경우 출력
            if (count == 0)
            {
                MessageBox.Show("취소할 상품이 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 리스트뷰에 해당 상품이 있는 경우 각 상품의 갯수와 총 가격을 초기화 함
            else if (listTotal.FocusedItem.SubItems[0].Text == txtPopcorn1.Text)
            {
                ord.popcorn1Cnt = 1;
                ord.popcorn1Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtPopcorn2.Text)
            {
                ord.popcorn2Cnt = 1;
                ord.popcorn2Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtPopcorn3.Text)
            {
                ord.popcorn3Cnt = 1;
                ord.popcorn3Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtPopcorn4.Text)
            {
                ord.popcorn4Cnt = 1;
                ord.popcorn4Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtDrink1.Text)
            {
                ord.drink1Cnt = 1;
                ord.drink1Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtDrink2.Text)
            {
                ord.drink2Cnt = 1;
                ord.drink2Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtDrink3.Text)
            {
                ord.drink3Cnt = 1;
                ord.drink3Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtDrink4.Text)
            {
                ord.drink4Cnt = 1;
                ord.drink4Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtSet1.Text)
            {
                ord.set1Cnt = 1;
                ord.set1Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtSet2.Text)
            {
                ord.set2Cnt = 1;
                ord.set2Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtSet3.Text)
            {
                ord.set3Cnt = 1;
                ord.set3Price = 0;
            }
            else if (listTotal.FocusedItem.SubItems[0].Text == txtSet4.Text)
            {
                ord.set4Cnt = 1;
                ord.set4Price = 0;
            }

            // 리스트뷰 목록에서 삭제
            listTotal.Items.Remove(listTotal.FocusedItem);
        }

        // 뒤로 버튼으로 이전 폼으로 돌아감
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            try
            {
                Conn.Open();
                string SQL = "SELECT * FROM TmpReservation";
                var Comm = new SqlCommand(SQL, Conn);
                var myRead = Comm.ExecuteReader(CommandBehavior.CloseConnection);

                // 예매를 하고 매점에서 추가 구할 경우 예매 결제창으로 넘어감
                if (myRead.Read())
                {
                    if (MessageBox.Show("매점 구매를 취소하고 예매 결제 창으로 가시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        결제정보창 frm7 = new 결제정보창();
                        frm7.Show();
                        this.Hide();
                    }
                }
                // 매점만 이용한 경우 홈 화면으로 넘어감
                else
                {
                    if (MessageBox.Show("매점 구매를 취소하고 홈으로 가시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        메뉴선택 frm1 = new 메뉴선택();
                        frm1.Show();
                        this.Hide();
                    }
                }

                myRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Conn.Close();
            }

        }

        // 리스트뷰에 상품 추가 후 결제 버튼을 누르면 임시 매점 구매 테이블에 저장됨
        private void btnSign_Click(object sender, EventArgs e)
        {
            var Conn = new SqlConnection(connectionStr);

            int count = listTotal.Items.Count;
            // 리스트뷰에 상품이 없을 경우 출력
            if (count == 0)
            {
                MessageBox.Show("결제할 상품이 없습니다!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Conn.Open();
                    string SQL = "INSERT INTO TmpBuySnack (SnackNum, SnackName, SnackPrice, BuyCount, BuyPrice) VALUES (@SnackNum, @SnackName, @SnackPrice, @BuyCount, @BuyPrice)";
                    var Comm = new SqlCommand(SQL, Conn);

                    Comm.Parameters.Add("@SnackNum", SqlDbType.VarChar, 10);
                    Comm.Parameters.Add("@SnackName", SqlDbType.NVarChar, 10);
                    Comm.Parameters.Add("@SnackPrice", SqlDbType.Int);
                    Comm.Parameters.Add("@BuyCount", SqlDbType.Int);
                    Comm.Parameters.Add("@BuyPrice", SqlDbType.Int);

                    // 리스트뷰에 있는 상품 갯수 만큼 반복하여 테이블에 저장
                    for (int i = 0; i < count; i++)
                    {
                        Comm.Parameters["@SnackNum"].Value = listTotal.Items[i].SubItems[0].Text;
                        Comm.Parameters["@SnackName"].Value = listTotal.Items[i].SubItems[1].Text;
                        Comm.Parameters["@SnackPrice"].Value = Convert.ToInt32(listTotal.Items[i].SubItems[2].Text);
                        Comm.Parameters["@BuyCount"].Value = Convert.ToInt32(listTotal.Items[i].SubItems[3].Text);
                        Comm.Parameters["@BuyPrice"].Value = Convert.ToInt32(listTotal.Items[i].SubItems[4].Text);

                        Comm.ExecuteNonQuery();
                    }
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("프로그램 실행중에 문제가 발생했습니다.  \r\n\r\n" + ex.Message, "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //데이터 베이스 접속을 종료함.
                    Conn.Close();
                }
                결제정보창 frm7 = new 결제정보창();
                frm7.Show();
                this.Hide();
            }
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
