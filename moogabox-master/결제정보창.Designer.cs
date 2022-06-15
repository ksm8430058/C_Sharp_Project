
namespace moogabox
{
	partial class 결제정보창
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(결제정보창));
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvMovie = new System.Windows.Forms.ListView();
            this.MvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SeatNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumMovie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumMovie = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMajum = new System.Windows.Forms.ListView();
            this.SnackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SnackNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumSnack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumMajum = new System.Windows.Forms.TextBox();
            this.txtSumTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Firebrick;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(735, 627);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(125, 48);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "결제하기";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvMovie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSumMovie);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1001, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예매 결제정보";
            // 
            // lvMovie
            // 
            this.lvMovie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MvName,
            this.StartTime,
            this.Hall,
            this.SeatNum,
            this.Count,
            this.SumMovie});
            this.lvMovie.FullRowSelect = true;
            this.lvMovie.GridLines = true;
            this.lvMovie.HideSelection = false;
            this.lvMovie.Location = new System.Drawing.Point(6, 29);
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(980, 120);
            this.lvMovie.TabIndex = 10;
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.View = System.Windows.Forms.View.Details;
            // 
            // MvName
            // 
            this.MvName.Text = "영화이름";
            this.MvName.Width = 250;
            // 
            // StartTime
            // 
            this.StartTime.Text = "시간";
            this.StartTime.Width = 200;
            // 
            // Hall
            // 
            this.Hall.Text = "상영관";
            this.Hall.Width = 150;
            // 
            // SeatNum
            // 
            this.SeatNum.Text = "좌석";
            this.SeatNum.Width = 143;
            // 
            // Count
            // 
            this.Count.Text = "수량";
            this.Count.Width = 100;
            // 
            // SumMovie
            // 
            this.SumMovie.Text = "합계";
            this.SumMovie.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "예매 금액 :";
            // 
            // txtSumMovie
            // 
            this.txtSumMovie.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumMovie.Location = new System.Drawing.Point(801, 164);
            this.txtSumMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSumMovie.Name = "txtSumMovie";
            this.txtSumMovie.ReadOnly = true;
            this.txtSumMovie.Size = new System.Drawing.Size(186, 33);
            this.txtSumMovie.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMajum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSumMajum);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(17, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1001, 216);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "매점 결제정보";
            // 
            // lvMajum
            // 
            this.lvMajum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SnackName,
            this.SnackNum,
            this.Price,
            this.Cout,
            this.SumSnack});
            this.lvMajum.FullRowSelect = true;
            this.lvMajum.GridLines = true;
            this.lvMajum.HideSelection = false;
            this.lvMajum.Location = new System.Drawing.Point(6, 19);
            this.lvMajum.Name = "lvMajum";
            this.lvMajum.Size = new System.Drawing.Size(980, 120);
            this.lvMajum.TabIndex = 11;
            this.lvMajum.UseCompatibleStateImageBehavior = false;
            this.lvMajum.View = System.Windows.Forms.View.Details;
            // 
            // SnackName
            // 
            this.SnackName.Text = "상품명";
            this.SnackName.Width = 250;
            // 
            // SnackNum
            // 
            this.SnackNum.Text = "상품번호";
            this.SnackNum.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "단가";
            this.Price.Width = 200;
            // 
            // Cout
            // 
            this.Cout.Text = "수량";
            this.Cout.Width = 180;
            // 
            // SumSnack
            // 
            this.SumSnack.Text = "합계";
            this.SumSnack.Width = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(699, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "매점 금액 :";
            // 
            // txtSumMajum
            // 
            this.txtSumMajum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumMajum.Location = new System.Drawing.Point(801, 162);
            this.txtSumMajum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSumMajum.Name = "txtSumMajum";
            this.txtSumMajum.Size = new System.Drawing.Size(186, 33);
            this.txtSumMajum.TabIndex = 1;
            // 
            // txtSumTotal
            // 
            this.txtSumTotal.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtSumTotal.Location = new System.Drawing.Point(197, 630);
            this.txtSumTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSumTotal.Name = "txtSumTotal";
            this.txtSumTotal.Size = new System.Drawing.Size(272, 43);
            this.txtSumTotal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "총 결제금액 :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(891, 627);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 48);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "처음으로";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 469);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 80);
            this.panel1.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(465, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 56);
            this.label6.TabIndex = 4;
            this.label6.Text = "결제";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::moogabox.Properties.Resources.moogabox;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1035, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSumMovie;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSumMajum;
		private System.Windows.Forms.TextBox txtSumTotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ListView lvMovie;
		private System.Windows.Forms.ColumnHeader MvName;
		private System.Windows.Forms.ColumnHeader StartTime;
		private System.Windows.Forms.ColumnHeader Hall;
		private System.Windows.Forms.ColumnHeader SeatNum;
		private System.Windows.Forms.ColumnHeader Count;
		private System.Windows.Forms.ColumnHeader SumMovie;
		private System.Windows.Forms.ListView lvMajum;
		private System.Windows.Forms.ColumnHeader SnackName;
		private System.Windows.Forms.ColumnHeader SnackNum;
		private System.Windows.Forms.ColumnHeader Price;
		private System.Windows.Forms.ColumnHeader Cout;
		private System.Windows.Forms.ColumnHeader SumSnack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
