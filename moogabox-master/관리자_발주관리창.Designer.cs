
namespace moogabox
{
    partial class 관리자_발주관리창
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(관리자_발주관리창));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.발주ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.입고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.창고입고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip3.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.listView1.ContextMenuStrip = this.contextMenuStrip3;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(43, 46);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(515, 143);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "이름";
			this.columnHeader8.Width = 134;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "S/N";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "개수";
			// 
			// contextMenuStrip3
			// 
			this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.발주ToolStripMenuItem1});
			this.contextMenuStrip3.Name = "contextMenuStrip3";
			this.contextMenuStrip3.Size = new System.Drawing.Size(99, 26);
			// 
			// 발주ToolStripMenuItem1
			// 
			this.발주ToolStripMenuItem1.Name = "발주ToolStripMenuItem1";
			this.발주ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
			this.발주ToolStripMenuItem1.Text = "발주";
			this.발주ToolStripMenuItem1.Click += new System.EventHandler(this.발주ToolStripMenuItem1_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "이름";
			this.columnHeader1.Width = 96;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "S/N";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "개수";
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.listView2.ContextMenuStrip = this.contextMenuStrip2;
			this.listView2.FullRowSelect = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(43, 221);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(515, 155);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView2_ColumnClick);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "이름";
			this.columnHeader4.Width = 133;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "S/N";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "개수";
			this.columnHeader6.Width = 70;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "발주번호";
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.입고ToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(99, 26);
			// 
			// 입고ToolStripMenuItem
			// 
			this.입고ToolStripMenuItem.Name = "입고ToolStripMenuItem";
			this.입고ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.입고ToolStripMenuItem.Text = "입고";
			this.입고ToolStripMenuItem.Click += new System.EventHandler(this.창고입고ToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Firebrick;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(669, 353);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "뒤로가기";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(41, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "창고재고";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(41, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "발주리스트";
			// 
			// 창고입고ToolStripMenuItem
			// 
			this.창고입고ToolStripMenuItem.Name = "창고입고ToolStripMenuItem";
			this.창고입고ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.창고입고ToolStripMenuItem.Text = "창고입고";
			this.창고입고ToolStripMenuItem.Click += new System.EventHandler(this.창고입고ToolStripMenuItem_Click);
			// 
			// ManagerForm5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ManagerForm5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "관리자(발주관리)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm5_FormClosing);
			this.Load += new System.EventHandler(this.ManagerForm5_Load);
			this.contextMenuStrip3.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 창고입고ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripMenuItem 입고ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 발주ToolStripMenuItem1;
    }
}