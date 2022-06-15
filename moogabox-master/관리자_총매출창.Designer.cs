
namespace moogabox
{
    partial class 관리자_총매출창
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
			System.Windows.Forms.ColumnHeader SnackName;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(관리자_총매출창));
			this.Btn_Stock = new System.Windows.Forms.Button();
			this.Btn_Sale = new System.Windows.Forms.Button();
			this.Btn_Cancle = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BuyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BuyCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SnackNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.View_TotalSale = new System.Windows.Forms.ListView();
			this.textTotal = new System.Windows.Forms.TextBox();
			this.btnSG = new System.Windows.Forms.Button();
			this.btnMG = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			SnackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// SnackName
			// 
			SnackName.Text = "Name";
			SnackName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			SnackName.Width = 150;
			// 
			// Btn_Stock
			// 
			this.Btn_Stock.Location = new System.Drawing.Point(351, 110);
			this.Btn_Stock.Name = "Btn_Stock";
			this.Btn_Stock.Size = new System.Drawing.Size(0, 0);
			this.Btn_Stock.TabIndex = 3;
			this.Btn_Stock.Text = "재고관리";
			this.Btn_Stock.UseVisualStyleBackColor = true;
			// 
			// Btn_Sale
			// 
			this.Btn_Sale.Location = new System.Drawing.Point(95, 137);
			this.Btn_Sale.Name = "Btn_Sale";
			this.Btn_Sale.Size = new System.Drawing.Size(0, 0);
			this.Btn_Sale.TabIndex = 2;
			this.Btn_Sale.Text = "매출관리";
			this.Btn_Sale.UseVisualStyleBackColor = true;
			// 
			// Btn_Cancle
			// 
			this.Btn_Cancle.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Cancle.FlatAppearance.BorderSize = 0;
			this.Btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Cancle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Cancle.ForeColor = System.Drawing.Color.White;
			this.Btn_Cancle.Location = new System.Drawing.Point(490, 414);
			this.Btn_Cancle.Name = "Btn_Cancle";
			this.Btn_Cancle.Size = new System.Drawing.Size(77, 24);
			this.Btn_Cancle.TabIndex = 11;
			this.Btn_Cancle.Text = "취소";
			this.Btn_Cancle.UseVisualStyleBackColor = false;
			this.Btn_Cancle.Click += new System.EventHandler(this.Btn_Cancle_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(179, 308);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "총 매출액";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(212, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 44);
			this.label1.TabIndex = 9;
			this.label1.Text = "총 판매수량";
			// 
			// BuyPrice
			// 
			this.BuyPrice.Text = "Price";
			this.BuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.BuyPrice.Width = 190;
			// 
			// BuyCount
			// 
			this.BuyCount.Text = "Count";
			this.BuyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.BuyCount.Width = 70;
			// 
			// SnackNum
			// 
			this.SnackNum.Text = "Number";
			this.SnackNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.SnackNum.Width = 120;
			// 
			// View_TotalSale
			// 
			this.View_TotalSale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            SnackName,
            this.BuyPrice,
            this.BuyCount,
            this.SnackNum});
			this.View_TotalSale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View_TotalSale.HideSelection = false;
			this.View_TotalSale.Location = new System.Drawing.Point(33, 53);
			this.View_TotalSale.Name = "View_TotalSale";
			this.View_TotalSale.Size = new System.Drawing.Size(534, 250);
			this.View_TotalSale.TabIndex = 12;
			this.View_TotalSale.UseCompatibleStateImageBehavior = false;
			this.View_TotalSale.View = System.Windows.Forms.View.Details;
			this.View_TotalSale.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.View_TotalSale_ColumnClick);
			this.View_TotalSale.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.View_TotalSale_ColumnWidthChanging);
			// 
			// textTotal
			// 
			this.textTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTotal.Location = new System.Drawing.Point(267, 310);
			this.textTotal.Name = "textTotal";
			this.textTotal.ReadOnly = true;
			this.textTotal.ShortcutsEnabled = false;
			this.textTotal.Size = new System.Drawing.Size(300, 23);
			this.textTotal.TabIndex = 13;
			this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnSG
			// 
			this.btnSG.BackColor = System.Drawing.Color.Firebrick;
			this.btnSG.FlatAppearance.BorderSize = 0;
			this.btnSG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSG.ForeColor = System.Drawing.Color.White;
			this.btnSG.Location = new System.Drawing.Point(407, 339);
			this.btnSG.Name = "btnSG";
			this.btnSG.Size = new System.Drawing.Size(160, 23);
			this.btnSG.TabIndex = 14;
			this.btnSG.Text = "스낵의 판매량 그래프";
			this.btnSG.UseVisualStyleBackColor = false;
			this.btnSG.Click += new System.EventHandler(this.btnSG_Click);
			// 
			// btnMG
			// 
			this.btnMG.BackColor = System.Drawing.Color.Firebrick;
			this.btnMG.FlatAppearance.BorderSize = 0;
			this.btnMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMG.ForeColor = System.Drawing.Color.White;
			this.btnMG.Location = new System.Drawing.Point(407, 368);
			this.btnMG.Name = "btnMG";
			this.btnMG.Size = new System.Drawing.Size(160, 23);
			this.btnMG.TabIndex = 15;
			this.btnMG.Text = "영화티켓 판매량 그래프";
			this.btnMG.UseVisualStyleBackColor = false;
			this.btnMG.Click += new System.EventHandler(this.btnMG_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 400);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(280, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			// 
			// ManagerForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(600, 450);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnMG);
			this.Controls.Add(this.btnSG);
			this.Controls.Add(this.textTotal);
			this.Controls.Add(this.View_TotalSale);
			this.Controls.Add(this.Btn_Cancle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn_Stock);
			this.Controls.Add(this.Btn_Sale);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ManagerForm2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManagerForm2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm2_FormClosing);
			this.Load += new System.EventHandler(this.ManagerForm2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Stock;
        private System.Windows.Forms.Button Btn_Sale;
        private System.Windows.Forms.Button Btn_Cancle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader BuyPrice;
        private System.Windows.Forms.ColumnHeader BuyCount;
        private System.Windows.Forms.ColumnHeader SnackNum;
        private System.Windows.Forms.ListView View_TotalSale;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button btnSG;
        private System.Windows.Forms.Button btnMG;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}