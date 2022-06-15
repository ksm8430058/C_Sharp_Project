
namespace moogabox
{
    partial class 관리자_첫화면
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(관리자_첫화면));
			this.Btn_Sale = new System.Windows.Forms.Button();
			this.Btn_Stock = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Btn_Sale
			// 
			this.Btn_Sale.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_Sale.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Btn_Sale.ForeColor = System.Drawing.Color.White;
			this.Btn_Sale.Location = new System.Drawing.Point(389, 12);
			this.Btn_Sale.Name = "Btn_Sale";
			this.Btn_Sale.Size = new System.Drawing.Size(165, 149);
			this.Btn_Sale.TabIndex = 0;
			this.Btn_Sale.Text = "매출관리";
			this.Btn_Sale.UseVisualStyleBackColor = false;
			this.Btn_Sale.Click += new System.EventHandler(this.Btn_Sale_Click);
			// 
			// Btn_Stock
			// 
			this.Btn_Stock.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_Stock.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Btn_Stock.ForeColor = System.Drawing.Color.White;
			this.Btn_Stock.Location = new System.Drawing.Point(389, 179);
			this.Btn_Stock.Name = "Btn_Stock";
			this.Btn_Stock.Size = new System.Drawing.Size(165, 149);
			this.Btn_Stock.TabIndex = 1;
			this.Btn_Stock.Text = "재고관리";
			this.Btn_Stock.UseVisualStyleBackColor = false;
			this.Btn_Stock.Click += new System.EventHandler(this.Btn_Stock_Click);
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
			// ManagerForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Btn_Stock);
			this.Controls.Add(this.Btn_Sale);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ManagerForm1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "관리자(관리선택)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sale;
        private System.Windows.Forms.Button Btn_Stock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}