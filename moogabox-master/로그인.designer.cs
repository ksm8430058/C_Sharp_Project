
namespace moogabox
{
    partial class 로그인
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(로그인));
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPw = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnSignup = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.iconButton5 = new FontAwesome.Sharp.IconButton();
			this.iconButton4 = new FontAwesome.Sharp.IconButton();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.iconButton2 = new FontAwesome.Sharp.IconButton();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtId.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtId.Location = new System.Drawing.Point(56, 332);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(211, 25);
			this.txtId.TabIndex = 2;
			// 
			// txtPw
			// 
			this.txtPw.BackColor = System.Drawing.SystemColors.Window;
			this.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPw.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtPw.Location = new System.Drawing.Point(56, 380);
			this.txtPw.Name = "txtPw";
			this.txtPw.PasswordChar = '*';
			this.txtPw.Size = new System.Drawing.Size(211, 25);
			this.txtPw.TabIndex = 3;
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnNext.Location = new System.Drawing.Point(58, 436);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(69, 34);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "로그인";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnSignup
			// 
			this.btnSignup.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignup.Location = new System.Drawing.Point(190, 436);
			this.btnSignup.Name = "btnSignup";
			this.btnSignup.Size = new System.Drawing.Size(77, 34);
			this.btnSignup.TabIndex = 5;
			this.btnSignup.Text = "회원가입";
			this.btnSignup.UseVisualStyleBackColor = false;
			this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.iconButton5);
			this.panel1.Controls.Add(this.btnSignup);
			this.panel1.Controls.Add(this.iconButton4);
			this.panel1.Controls.Add(this.iconButton3);
			this.panel1.Controls.Add(this.iconButton2);
			this.panel1.Controls.Add(this.iconButton1);
			this.panel1.Controls.Add(this.txtPw);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.txtId);
			this.panel1.Controls.Add(this.btnNext);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 542);
			this.panel1.TabIndex = 6;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// iconButton5
			// 
			this.iconButton5.BackColor = System.Drawing.SystemColors.Desktop;
			this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.iconButton5.FlatAppearance.BorderSize = 0;
			this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
			this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton5.IconColor = System.Drawing.Color.Black;
			this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton5.Location = new System.Drawing.Point(0, 519);
			this.iconButton5.Name = "iconButton5";
			this.iconButton5.Size = new System.Drawing.Size(284, 23);
			this.iconButton5.TabIndex = 13;
			this.iconButton5.Text = "By Team Danawa.";
			this.iconButton5.UseVisualStyleBackColor = false;
			// 
			// iconButton4
			// 
			this.iconButton4.BackColor = System.Drawing.SystemColors.Desktop;
			this.iconButton4.FlatAppearance.BorderSize = 0;
			this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
			this.iconButton4.IconColor = System.Drawing.Color.White;
			this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton4.IconSize = 30;
			this.iconButton4.Location = new System.Drawing.Point(159, 439);
			this.iconButton4.Name = "iconButton4";
			this.iconButton4.Size = new System.Drawing.Size(35, 29);
			this.iconButton4.TabIndex = 11;
			this.iconButton4.UseVisualStyleBackColor = false;
			// 
			// iconButton3
			// 
			this.iconButton3.BackColor = System.Drawing.SystemColors.Desktop;
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
			this.iconButton3.IconColor = System.Drawing.Color.White;
			this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton3.IconSize = 25;
			this.iconButton3.Location = new System.Drawing.Point(21, 439);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Size = new System.Drawing.Size(35, 29);
			this.iconButton3.TabIndex = 10;
			this.iconButton3.UseVisualStyleBackColor = false;
			// 
			// iconButton2
			// 
			this.iconButton2.BackColor = System.Drawing.SystemColors.Desktop;
			this.iconButton2.FlatAppearance.BorderSize = 0;
			this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
			this.iconButton2.IconColor = System.Drawing.Color.White;
			this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton2.IconSize = 25;
			this.iconButton2.Location = new System.Drawing.Point(21, 380);
			this.iconButton2.Name = "iconButton2";
			this.iconButton2.Size = new System.Drawing.Size(35, 29);
			this.iconButton2.TabIndex = 9;
			this.iconButton2.UseVisualStyleBackColor = false;
			// 
			// iconButton1
			// 
			this.iconButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
			this.iconButton1.IconColor = System.Drawing.Color.White;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 30;
			this.iconButton1.Location = new System.Drawing.Point(18, 330);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(35, 37);
			this.iconButton1.TabIndex = 8;
			this.iconButton1.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(286, 297);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form0
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(287, 545);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form0";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "로그인";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form0_FormClosing);
			this.Load += new System.EventHandler(this.Form0_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}

