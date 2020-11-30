namespace CoffeeShop
{
	partial class fTableManager
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogOut = new System.Windows.Forms.ToolStripMenuItem();
			this.fpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nmAmount = new System.Windows.Forms.NumericUpDown();
			this.cbFood = new System.Windows.Forms.ComboBox();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbSwitchTable = new System.Windows.Forms.ComboBox();
			this.btnSwitchTable = new System.Windows.Forms.Button();
			this.nmDiscount = new System.Windows.Forms.NumericUpDown();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lvFood = new System.Windows.Forms.ListView();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmAmount)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmin,
            this.thôngTinTàiKhoảnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuAdmin
			// 
			this.menuAdmin.Name = "menuAdmin";
			this.menuAdmin.Size = new System.Drawing.Size(55, 20);
			this.menuAdmin.Text = "Admin";
			this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPersonalInfo,
            this.menuLogOut});
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// menuPersonalInfo
			// 
			this.menuPersonalInfo.Name = "menuPersonalInfo";
			this.menuPersonalInfo.Size = new System.Drawing.Size(171, 22);
			this.menuPersonalInfo.Text = "Thông tin cá nhân";
			this.menuPersonalInfo.Click += new System.EventHandler(this.menuPersonalInfo_Click);
			// 
			// menuLogOut
			// 
			this.menuLogOut.Name = "menuLogOut";
			this.menuLogOut.Size = new System.Drawing.Size(171, 22);
			this.menuLogOut.Text = "Đăng xuất";
			this.menuLogOut.Click += new System.EventHandler(this.menuLogOut_Click);
			// 
			// fpTable
			// 
			this.fpTable.AutoScroll = true;
			this.fpTable.Location = new System.Drawing.Point(12, 27);
			this.fpTable.Name = "fpTable";
			this.fpTable.Size = new System.Drawing.Size(375, 522);
			this.fpTable.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.nmAmount);
			this.panel1.Controls.Add(this.cbFood);
			this.panel1.Controls.Add(this.cbCategory);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Location = new System.Drawing.Point(393, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(379, 70);
			this.panel1.TabIndex = 2;
			// 
			// nmAmount
			// 
			this.nmAmount.Location = new System.Drawing.Point(322, 28);
			this.nmAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmAmount.Name = "nmAmount";
			this.nmAmount.Size = new System.Drawing.Size(53, 20);
			this.nmAmount.TabIndex = 3;
			this.nmAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nmAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cbFood
			// 
			this.cbFood.FormattingEnabled = true;
			this.cbFood.Location = new System.Drawing.Point(3, 39);
			this.cbFood.Name = "cbFood";
			this.cbFood.Size = new System.Drawing.Size(208, 21);
			this.cbFood.TabIndex = 2;
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(3, 12);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(208, 21);
			this.cbCategory.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(217, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(99, 48);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm món";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cbSwitchTable);
			this.panel2.Controls.Add(this.btnSwitchTable);
			this.panel2.Controls.Add(this.nmDiscount);
			this.panel2.Controls.Add(this.btnDiscount);
			this.panel2.Controls.Add(this.btnCheckout);
			this.panel2.Location = new System.Drawing.Point(393, 479);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(379, 70);
			this.panel2.TabIndex = 3;
			// 
			// cbSwitchTable
			// 
			this.cbSwitchTable.FormattingEnabled = true;
			this.cbSwitchTable.Location = new System.Drawing.Point(3, 46);
			this.cbSwitchTable.Name = "cbSwitchTable";
			this.cbSwitchTable.Size = new System.Drawing.Size(99, 21);
			this.cbSwitchTable.TabIndex = 4;
			// 
			// btnSwitchTable
			// 
			this.btnSwitchTable.Location = new System.Drawing.Point(3, 3);
			this.btnSwitchTable.Name = "btnSwitchTable";
			this.btnSwitchTable.Size = new System.Drawing.Size(99, 33);
			this.btnSwitchTable.TabIndex = 6;
			this.btnSwitchTable.Text = "Chuyển bàn";
			this.btnSwitchTable.UseVisualStyleBackColor = true;
			// 
			// nmDiscount
			// 
			this.nmDiscount.Location = new System.Drawing.Point(140, 47);
			this.nmDiscount.Name = "nmDiscount";
			this.nmDiscount.Size = new System.Drawing.Size(99, 20);
			this.nmDiscount.TabIndex = 4;
			this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnDiscount
			// 
			this.btnDiscount.Location = new System.Drawing.Point(140, 3);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(99, 33);
			this.btnDiscount.TabIndex = 5;
			this.btnDiscount.Text = "Giảm giá";
			this.btnDiscount.UseVisualStyleBackColor = true;
			// 
			// btnCheckout
			// 
			this.btnCheckout.Location = new System.Drawing.Point(276, 11);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(99, 48);
			this.btnCheckout.TabIndex = 4;
			this.btnCheckout.Text = "Thanh toán";
			this.btnCheckout.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lvFood);
			this.panel3.Location = new System.Drawing.Point(393, 103);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(379, 370);
			this.panel3.TabIndex = 3;
			// 
			// lvFood
			// 
			this.lvFood.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvFood.Location = new System.Drawing.Point(0, 0);
			this.lvFood.Name = "lvFood";
			this.lvFood.Size = new System.Drawing.Size(379, 370);
			this.lvFood.TabIndex = 0;
			this.lvFood.UseCompatibleStateImageBehavior = false;
			// 
			// fTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.fpTable);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "fTableManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần Mềm Quản Lý Quán Cà Phê";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmAmount)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuAdmin;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuPersonalInfo;
		private System.Windows.Forms.ToolStripMenuItem menuLogOut;
		private System.Windows.Forms.FlowLayoutPanel fpTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ListView lvFood;
		private System.Windows.Forms.NumericUpDown nmAmount;
		private System.Windows.Forms.ComboBox cbFood;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCheckout;
		private System.Windows.Forms.ComboBox cbSwitchTable;
		private System.Windows.Forms.Button btnSwitchTable;
		private System.Windows.Forms.NumericUpDown nmDiscount;
		private System.Windows.Forms.Button btnDiscount;
	}
}