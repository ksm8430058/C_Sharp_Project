
namespace moogabox
{
    partial class 예매조회
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(예매조회));
			this.Btn_Next = new System.Windows.Forms.Button();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnNext2 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNext0 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.iconButton5 = new FontAwesome.Sharp.IconButton();
			this.iconButton6 = new FontAwesome.Sharp.IconButton();
			this.iconButton3 = new FontAwesome.Sharp.IconButton();
			this.btnNext2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Next
			// 
			this.Btn_Next.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Next.FlatAppearance.BorderSize = 0;
			this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Next.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.Btn_Next.ForeColor = System.Drawing.Color.White;
			this.Btn_Next.Location = new System.Drawing.Point(243, 259);
			this.Btn_Next.Name = "Btn_Next";
			this.Btn_Next.Size = new System.Drawing.Size(125, 48);
			this.Btn_Next.TabIndex = 0;
			this.Btn_Next.Text = "다  음";
			this.Btn_Next.UseVisualStyleBackColor = false;
			this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
			// 
			// txtNum
			// 
			this.txtNum.BackColor = System.Drawing.Color.White;
			this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNum.ForeColor = System.Drawing.Color.Black;
			this.txtNum.Location = new System.Drawing.Point(131, 145);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(237, 43);
			this.txtNum.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 145);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "입력 :";
			// 
			// btnNext2
			// 
			this.btnNext2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.btnNext2.Controls.Add(this.tabPage1);
			this.btnNext2.Controls.Add(this.tabPage2);
			this.btnNext2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext2.ItemSize = new System.Drawing.Size(110, 40);
			this.btnNext2.Location = new System.Drawing.Point(511, 162);
			this.btnNext2.Name = "btnNext2";
			this.btnNext2.SelectedIndex = 0;
			this.btnNext2.Size = new System.Drawing.Size(505, 496);
			this.btnNext2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.btnNext2.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Black;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(497, 448);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "예매번호";
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Btn_Next);
			this.groupBox1.Controls.Add(this.txtNum);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(34, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(425, 360);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "예매번호 조회";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Black;
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tabPage2.Location = new System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(497, 448);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "전화번호";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtPhone);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnNext0);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(34, 36);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(425, 360);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "전화번호 조회";
			// 
			// txtPhone
			// 
			this.txtPhone.BackColor = System.Drawing.Color.White;
			this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.ForeColor = System.Drawing.Color.Black;
			this.txtPhone.Location = new System.Drawing.Point(131, 145);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(237, 43);
			this.txtPhone.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(44, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 36);
			this.label3.TabIndex = 2;
			this.label3.Text = "입력 :";
			// 
			// btnNext0
			// 
			this.btnNext0.BackColor = System.Drawing.Color.Firebrick;
			this.btnNext0.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnNext0.FlatAppearance.BorderSize = 0;
			this.btnNext0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext0.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.btnNext0.ForeColor = System.Drawing.Color.White;
			this.btnNext0.Location = new System.Drawing.Point(243, 259);
			this.btnNext0.Name = "btnNext0";
			this.btnNext0.Size = new System.Drawing.Size(125, 48);
			this.btnNext0.TabIndex = 0;
			this.btnNext0.Text = "다  음";
			this.btnNext0.UseVisualStyleBackColor = false;
			this.btnNext0.Click += new System.EventHandler(this.btnNext0_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnNext2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1019, 661);
			this.panel1.TabIndex = 6;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 55);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1019, 80);
			this.panel3.TabIndex = 66;
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
			this.label2.Text = "예매 조회";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::moogabox.Properties.Resources.moogabox;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1019, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 65;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.iconButton5);
			this.panel2.Controls.Add(this.iconButton6);
			this.panel2.Controls.Add(this.iconButton3);
			this.panel2.Location = new System.Drawing.Point(3, 162);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(505, 496);
			this.panel2.TabIndex = 14;
			// 
			// iconButton5
			// 
			this.iconButton5.BackColor = System.Drawing.Color.Black;
			this.iconButton5.FlatAppearance.BorderSize = 0;
			this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton5.ForeColor = System.Drawing.Color.White;
			this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton5.IconColor = System.Drawing.Color.Black;
			this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton5.Location = new System.Drawing.Point(45, 198);
			this.iconButton5.Name = "iconButton5";
			this.iconButton5.Size = new System.Drawing.Size(414, 80);
			this.iconButton5.TabIndex = 15;
			this.iconButton5.Text = "◎ 예매 방법에 따라서 예매 정보 조회가 불가능 할 수 있습니다.";
			this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton5.UseVisualStyleBackColor = false;
			// 
			// iconButton6
			// 
			this.iconButton6.BackColor = System.Drawing.Color.Black;
			this.iconButton6.FlatAppearance.BorderSize = 0;
			this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton6.ForeColor = System.Drawing.Color.White;
			this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton6.IconColor = System.Drawing.Color.Black;
			this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton6.Location = new System.Drawing.Point(45, 360);
			this.iconButton6.Name = "iconButton6";
			this.iconButton6.Size = new System.Drawing.Size(414, 80);
			this.iconButton6.TabIndex = 14;
			this.iconButton6.Text = "◎ 발권번호를 모르는 고객께서는 휴대폰 번호로 조회해 주세요.";
			this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton6.UseVisualStyleBackColor = false;
			// 
			// iconButton3
			// 
			this.iconButton3.BackColor = System.Drawing.Color.Black;
			this.iconButton3.FlatAppearance.BorderSize = 0;
			this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButton3.ForeColor = System.Drawing.Color.White;
			this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
			this.iconButton3.IconColor = System.Drawing.Color.Black;
			this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton3.Location = new System.Drawing.Point(45, 44);
			this.iconButton3.Name = "iconButton3";
			this.iconButton3.Size = new System.Drawing.Size(414, 80);
			this.iconButton3.TabIndex = 11;
			this.iconButton3.Text = "◎ 모든 예매 정보는 예매번호로 조회가 가능합니다.";
			this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButton3.UseVisualStyleBackColor = false;
			this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 661);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "예매조회";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.btnNext2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl btnNext2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext0;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

