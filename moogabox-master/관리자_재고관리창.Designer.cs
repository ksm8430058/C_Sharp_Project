
namespace moogabox
{
    partial class 관리자_재고관리창
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(관리자_재고관리창));
			this.View_StoreStock = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.생산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.View_WearhouseStock = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.View_Order = new System.Windows.Forms.ListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.Btn_Back = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// View_StoreStock
			// 
			this.View_StoreStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.View_StoreStock.ContextMenuStrip = this.contextMenuStrip1;
			this.View_StoreStock.HideSelection = false;
			this.View_StoreStock.Location = new System.Drawing.Point(26, 42);
			this.View_StoreStock.Name = "View_StoreStock";
			this.View_StoreStock.Size = new System.Drawing.Size(251, 148);
			this.View_StoreStock.TabIndex = 0;
			this.View_StoreStock.UseCompatibleStateImageBehavior = false;
			this.View_StoreStock.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "이름";
			this.columnHeader1.Width = 114;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "S/N";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "개수";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.생산ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
			// 
			// 생산ToolStripMenuItem
			// 
			this.생산ToolStripMenuItem.Name = "생산ToolStripMenuItem";
			this.생산ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.생산ToolStripMenuItem.Text = "생산";
			this.생산ToolStripMenuItem.Click += new System.EventHandler(this.생산ToolStripMenuItem_Click);
			// 
			// View_WearhouseStock
			// 
			this.View_WearhouseStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.View_WearhouseStock.HideSelection = false;
			this.View_WearhouseStock.Location = new System.Drawing.Point(295, 42);
			this.View_WearhouseStock.Name = "View_WearhouseStock";
			this.View_WearhouseStock.Size = new System.Drawing.Size(257, 148);
			this.View_WearhouseStock.TabIndex = 1;
			this.View_WearhouseStock.UseCompatibleStateImageBehavior = false;
			this.View_WearhouseStock.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "이름";
			this.columnHeader4.Width = 110;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "S/N";
			this.columnHeader5.Width = 50;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "개수";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(24, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "매장재고";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(293, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "창고재고";
			// 
			// View_Order
			// 
			this.View_Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.View_Order.HideSelection = false;
			this.View_Order.Location = new System.Drawing.Point(26, 229);
			this.View_Order.Name = "View_Order";
			this.View_Order.Size = new System.Drawing.Size(399, 116);
			this.View_Order.TabIndex = 4;
			this.View_Order.UseCompatibleStateImageBehavior = false;
			this.View_Order.View = System.Windows.Forms.View.Details;
			this.View_Order.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.View_Order_ColumnClick);
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "이름";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "S/N";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "개수";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "입고번호";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "입고현황";
			// 
			// Btn_Back
			// 
			this.Btn_Back.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_Back.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Btn_Back.ForeColor = System.Drawing.Color.White;
			this.Btn_Back.Location = new System.Drawing.Point(486, 321);
			this.Btn_Back.Name = "Btn_Back";
			this.Btn_Back.Size = new System.Drawing.Size(66, 24);
			this.Btn_Back.TabIndex = 6;
			this.Btn_Back.Text = "뒤로가기";
			this.Btn_Back.UseVisualStyleBackColor = false;
			this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Firebrick;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(486, 290);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(66, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "발주";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ManagerForm4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Btn_Back);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.View_Order);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.View_WearhouseStock);
			this.Controls.Add(this.View_StoreStock);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ManagerForm4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "관리자(재고관리)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm4_FormClosing);
			this.Load += new System.EventHandler(this.ManagerForm4_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView View_StoreStock;
        private System.Windows.Forms.ListView View_WearhouseStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView View_Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 생산ToolStripMenuItem;
    }
}