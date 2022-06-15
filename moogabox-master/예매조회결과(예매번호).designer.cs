
namespace moogabox
{
    partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.pbMovie = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.lblHall = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.lblSeat = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbSitnum = new System.Windows.Forms.Label();
			this.lbTime = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pbMovie
			// 
			this.pbMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbMovie.ErrorImage = null;
			this.pbMovie.Location = new System.Drawing.Point(74, 162);
			this.pbMovie.Name = "pbMovie";
			this.pbMovie.Size = new System.Drawing.Size(322, 462);
			this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbMovie.TabIndex = 6;
			this.pbMovie.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(52, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 32);
			this.label7.TabIndex = 10;
			this.label7.Text = "예매현황";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.iconButton1);
			this.panel2.Controls.Add(this.pbMovie);
			this.panel2.Controls.Add(this.lblHall);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.lbTitle);
			this.panel2.Controls.Add(this.lblSeat);
			this.panel2.Controls.Add(this.lblName);
			this.panel2.Controls.Add(this.lblTime);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lbSitnum);
			this.panel2.Controls.Add(this.lbTime);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1035, 700);
			this.panel2.TabIndex = 12;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1035, 80);
			this.panel1.TabIndex = 66;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(411, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 56);
			this.label2.TabIndex = 4;
			this.label2.Text = "예매 확인";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::moogabox.Properties.Resources.moogabox;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1035, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 65;
			this.pictureBox1.TabStop = false;
			// 
			// iconButton1
			// 
			this.iconButton1.BackColor = System.Drawing.Color.Firebrick;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton1.ForeColor = System.Drawing.Color.White;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton1.IconColor = System.Drawing.Color.Empty;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.Location = new System.Drawing.Point(878, 610);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(125, 48);
			this.iconButton1.TabIndex = 13;
			this.iconButton1.Text = "발  권";
			this.iconButton1.UseVisualStyleBackColor = false;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// lblHall
			// 
			this.lblHall.AutoSize = true;
			this.lblHall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblHall.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblHall.Location = new System.Drawing.Point(648, 393);
			this.lblHall.Name = "lblHall";
			this.lblHall.Size = new System.Drawing.Size(68, 36);
			this.lblHall.TabIndex = 9;
			this.lblHall.Text = "Hall";
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbTitle.Location = new System.Drawing.Point(526, 225);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(81, 36);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "영화 :";
			// 
			// lblSeat
			// 
			this.lblSeat.AutoSize = true;
			this.lblSeat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblSeat.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSeat.Location = new System.Drawing.Point(648, 477);
			this.lblSeat.Name = "lblSeat";
			this.lblSeat.Size = new System.Drawing.Size(77, 36);
			this.lblSeat.TabIndex = 9;
			this.lblSeat.Text = "Seat";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblName.Location = new System.Drawing.Point(639, 225);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(101, 36);
			this.lblName.TabIndex = 7;
			this.lblName.Text = "Name";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblTime.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTime.Location = new System.Drawing.Point(639, 306);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(80, 36);
			this.lblTime.TabIndex = 8;
			this.lblTime.Text = "Time";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(501, 393);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "상영관 :";
			// 
			// lbSitnum
			// 
			this.lbSitnum.AutoSize = true;
			this.lbSitnum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbSitnum.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSitnum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbSitnum.Location = new System.Drawing.Point(526, 477);
			this.lbSitnum.Name = "lbSitnum";
			this.lbSitnum.Size = new System.Drawing.Size(81, 36);
			this.lbSitnum.TabIndex = 2;
			this.lbSitnum.Text = "좌석 :";
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbTime.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbTime.Location = new System.Drawing.Point(476, 306);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(131, 36);
			this.lbTime.TabIndex = 1;
			this.lbTime.Text = "상영시간 :";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1035, 700);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "예매현황";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSitnum;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}