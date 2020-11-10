namespace Lab06_Basic_Command
{
	partial class Form1
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.lvCategory = new System.Windows.Forms.ListView();
			this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.btnBills = new System.Windows.Forms.Button();
			this.btnAccount = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 85);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(159, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Lấy danh sách";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lvCategory
			// 
			this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
			this.lvCategory.ContextMenuStrip = this.contextMenuStrip1;
			this.lvCategory.FullRowSelect = true;
			this.lvCategory.Location = new System.Drawing.Point(12, 114);
			this.lvCategory.MultiSelect = false;
			this.lvCategory.Name = "lvCategory";
			this.lvCategory.Size = new System.Drawing.Size(628, 324);
			this.lvCategory.TabIndex = 1;
			this.lvCategory.UseCompatibleStateImageBehavior = false;
			this.lvCategory.View = System.Windows.Forms.View.Details;
			this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
			// 
			// chID
			// 
			this.chID.Text = "Mã Loại";
			this.chID.Width = 158;
			// 
			// chName
			// 
			this.chName.Text = "Tên loại món ăn";
			this.chName.Width = 325;
			// 
			// chType
			// 
			this.chType.Text = "Loại";
			this.chType.Width = 139;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(189, 48);
			// 
			// tsmDelete
			// 
			this.tsmDelete.Name = "tsmDelete";
			this.tsmDelete.Size = new System.Drawing.Size(188, 22);
			this.tsmDelete.Text = "Xóa nhóm sản phẩm";
			this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
			// 
			// tsmViewFood
			// 
			this.tsmViewFood.Name = "tsmViewFood";
			this.tsmViewFood.Size = new System.Drawing.Size(188, 22);
			this.tsmViewFood.Text = "Xem nhóm sản phẩm";
			this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(514, 85);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(126, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(369, 85);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(126, 23);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(223, 85);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(126, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(138, 12);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(223, 20);
			this.txtID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mã nhóm:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tên nhóm thức ăn:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Loại:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(138, 34);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(223, 20);
			this.txtName.TabIndex = 2;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(138, 57);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(223, 20);
			this.txtType.TabIndex = 3;
			// 
			// btnBills
			// 
			this.btnBills.Location = new System.Drawing.Point(514, 9);
			this.btnBills.Name = "btnBills";
			this.btnBills.Size = new System.Drawing.Size(126, 23);
			this.btnBills.TabIndex = 9;
			this.btnBills.Text = "Xem hóa đơn";
			this.btnBills.UseVisualStyleBackColor = true;
			this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
			// 
			// btnAccount
			// 
			this.btnAccount.Location = new System.Drawing.Point(514, 50);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new System.Drawing.Size(126, 23);
			this.btnAccount.TabIndex = 10;
			this.btnAccount.Text = "Xem tài khoản";
			this.btnAccount.UseVisualStyleBackColor = true;
			this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 450);
			this.Controls.Add(this.btnAccount);
			this.Controls.Add(this.btnBills);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lvCategory);
			this.Controls.Add(this.btnLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ListView lvCategory;
		private System.Windows.Forms.ColumnHeader chID;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnAccount;
	}
}

