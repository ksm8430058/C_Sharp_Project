
namespace moogabox
{
    partial class 관리자_재고메뉴선택창
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(관리자_재고메뉴선택창));
			this.Btn_StoreStock = new System.Windows.Forms.Button();
			this.Btn_WarehouseStock = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Btn_StoreStock
			// 
			this.Btn_StoreStock.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_StoreStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_StoreStock.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Btn_StoreStock.ForeColor = System.Drawing.Color.White;
			this.Btn_StoreStock.Location = new System.Drawing.Point(389, 12);
			this.Btn_StoreStock.Name = "Btn_StoreStock";
			this.Btn_StoreStock.Size = new System.Drawing.Size(165, 149);
			this.Btn_StoreStock.TabIndex = 0;
			this.Btn_StoreStock.TabStop = false;
			this.Btn_StoreStock.Text = "매장재고";
			this.Btn_StoreStock.UseVisualStyleBackColor = false;
			this.Btn_StoreStock.Click += new System.EventHandler(this.Btn_StoreStock_Click);
			// 
			// Btn_WarehouseStock
			// 
			this.Btn_WarehouseStock.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_WarehouseStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_WarehouseStock.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Btn_WarehouseStock.ForeColor = System.Drawing.Color.White;
			this.Btn_WarehouseStock.Location = new System.Drawing.Point(389, 179);
			this.Btn_WarehouseStock.Name = "Btn_WarehouseStock";
			this.Btn_WarehouseStock.Size = new System.Drawing.Size(165, 149);
			this.Btn_WarehouseStock.TabIndex = 1;
			this.Btn_WarehouseStock.Text = "창고재고";
			this.Btn_WarehouseStock.UseVisualStyleBackColor = false;
			this.Btn_WarehouseStock.Click += new System.EventHandler(this.Btn_WarehouseStock_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Firebrick;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(479, 366);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "뒤로가기";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(362, 316);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// ManagerForm3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Btn_WarehouseStock);
			this.Controls.Add(this.Btn_StoreStock);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ManagerForm3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "관리자(재고선택)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm3_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_StoreStock;
        private System.Windows.Forms.Button Btn_WarehouseStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}