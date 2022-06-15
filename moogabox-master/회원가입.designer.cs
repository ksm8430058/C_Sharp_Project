
namespace moogabox
{
    partial class 회원가입
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(회원가입));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtPW = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbManager = new System.Windows.Forms.RadioButton();
			this.rbNormal = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbMooga1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbMooga1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.txtPW);
			this.panel1.Controls.Add(this.txtID);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblID);
			this.panel1.Location = new System.Drawing.Point(17, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(330, 335);
			this.panel1.TabIndex = 0;
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("굴림", 10F);
			this.txtPhone.Location = new System.Drawing.Point(123, 146);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(164, 23);
			this.txtPhone.TabIndex = 4;
			// 
			// txtPW
			// 
			this.txtPW.Font = new System.Drawing.Font("굴림", 10F);
			this.txtPW.Location = new System.Drawing.Point(123, 93);
			this.txtPW.Name = "txtPW";
			this.txtPW.PasswordChar = '*';
			this.txtPW.Size = new System.Drawing.Size(164, 23);
			this.txtPW.TabIndex = 4;
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("굴림", 10F);
			this.txtID.Location = new System.Drawing.Point(123, 38);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(164, 23);
			this.txtID.TabIndex = 4;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.Firebrick;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.Location = new System.Drawing.Point(20, 284);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(79, 31);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "뒤로가기";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Firebrick;
			this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.ForeColor = System.Drawing.Color.White;
			this.btnOK.Location = new System.Drawing.Point(237, 284);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(79, 31);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "확인";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbManager);
			this.groupBox1.Controls.Add(this.rbNormal);
			this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
			this.groupBox1.Location = new System.Drawing.Point(47, 193);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 54);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "회원유형";
			// 
			// rbManager
			// 
			this.rbManager.AutoSize = true;
			this.rbManager.ForeColor = System.Drawing.Color.White;
			this.rbManager.Location = new System.Drawing.Point(139, 22);
			this.rbManager.Name = "rbManager";
			this.rbManager.Size = new System.Drawing.Size(61, 19);
			this.rbManager.TabIndex = 0;
			this.rbManager.TabStop = true;
			this.rbManager.Text = "관리자";
			this.rbManager.UseVisualStyleBackColor = true;
			// 
			// rbNormal
			// 
			this.rbNormal.AutoSize = true;
			this.rbNormal.ForeColor = System.Drawing.Color.White;
			this.rbNormal.Location = new System.Drawing.Point(34, 22);
			this.rbNormal.Name = "rbNormal";
			this.rbNormal.Size = new System.Drawing.Size(73, 19);
			this.rbNormal.TabIndex = 0;
			this.rbNormal.TabStop = true;
			this.rbNormal.Text = "일반회원";
			this.rbNormal.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(11, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "PhoneNum : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(71, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "PW :";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
			this.lblID.ForeColor = System.Drawing.Color.White;
			this.lblID.Location = new System.Drawing.Point(80, 37);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(37, 21);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(133, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "회원가입";
			// 
			// pbMooga1
			// 
			this.pbMooga1.Location = new System.Drawing.Point(38, 405);
			this.pbMooga1.Name = "pbMooga1";
			this.pbMooga1.Size = new System.Drawing.Size(296, 50);
			this.pbMooga1.TabIndex = 2;
			this.pbMooga1.TabStop = false;
			// 
			// Form10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(365, 472);
			this.Controls.Add(this.pbMooga1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form10";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "회원가입";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form10_FormClosing);
			this.Load += new System.EventHandler(this.Form10_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbMooga1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbMooga1;
    }
}