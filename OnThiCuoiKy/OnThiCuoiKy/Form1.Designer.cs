namespace OnThiCuoiKy
{
	partial class frmMain
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvBanAn = new System.Windows.Forms.DataGridView();
			this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIDBanAn = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.cbTrangThaiBanAn = new System.Windows.Forms.ComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtTenBanAn = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.nmSoChoNgoi = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmSoChoNgoi)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvBanAn);
			this.groupBox1.Location = new System.Drawing.Point(0, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(464, 502);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách bàn ăn";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel4);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnCapNhat);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(470, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(456, 152);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin bàn ăn";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvChiTietHD);
			this.groupBox3.Location = new System.Drawing.Point(470, 159);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(456, 344);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chi tiết hóa đơn";
			// 
			// dgvBanAn
			// 
			this.dgvBanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBanAn.BackgroundColor = System.Drawing.Color.White;
			this.dgvBanAn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBanAn.Location = new System.Drawing.Point(3, 16);
			this.dgvBanAn.MultiSelect = false;
			this.dgvBanAn.Name = "dgvBanAn";
			this.dgvBanAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBanAn.Size = new System.Drawing.Size(458, 483);
			this.dgvBanAn.TabIndex = 0;
			this.dgvBanAn.Click += new System.EventHandler(this.dgvBanAn_Click);
			// 
			// dgvChiTietHD
			// 
			this.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvChiTietHD.BackgroundColor = System.Drawing.Color.White;
			this.dgvChiTietHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvChiTietHD.Location = new System.Drawing.Point(3, 16);
			this.dgvChiTietHD.MultiSelect = false;
			this.dgvChiTietHD.Name = "dgvChiTietHD";
			this.dgvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvChiTietHD.Size = new System.Drawing.Size(450, 325);
			this.dgvChiTietHD.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtIDBanAn);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(6, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 34);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// txtIDBanAn
			// 
			this.txtIDBanAn.Location = new System.Drawing.Point(30, 8);
			this.txtIDBanAn.Name = "txtIDBanAn";
			this.txtIDBanAn.ReadOnly = true;
			this.txtIDBanAn.Size = new System.Drawing.Size(130, 20);
			this.txtIDBanAn.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cbTrangThaiBanAn);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(213, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(232, 34);
			this.panel2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Trạng thái:";
			// 
			// cbTrangThaiBanAn
			// 
			this.cbTrangThaiBanAn.FormattingEnabled = true;
			this.cbTrangThaiBanAn.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
			this.cbTrangThaiBanAn.Location = new System.Drawing.Point(67, 8);
			this.cbTrangThaiBanAn.Name = "cbTrangThaiBanAn";
			this.cbTrangThaiBanAn.Size = new System.Drawing.Size(155, 21);
			this.cbTrangThaiBanAn.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtTenBanAn);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(6, 65);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(280, 34);
			this.panel3.TabIndex = 2;
			// 
			// txtTenBanAn
			// 
			this.txtTenBanAn.Location = new System.Drawing.Point(74, 8);
			this.txtTenBanAn.Name = "txtTenBanAn";
			this.txtTenBanAn.Size = new System.Drawing.Size(194, 20);
			this.txtTenBanAn.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên bàn ăn:";
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(6, 117);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(199, 117);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
			this.btnCapNhat.TabIndex = 4;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(370, 117);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 5;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nmSoChoNgoi);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(292, 65);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(153, 34);
			this.panel4.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số chỗ ngồi:";
			// 
			// nmSoChoNgoi
			// 
			this.nmSoChoNgoi.Location = new System.Drawing.Point(74, 9);
			this.nmSoChoNgoi.Name = "nmSoChoNgoi";
			this.nmSoChoNgoi.Size = new System.Drawing.Size(69, 20);
			this.nmSoChoNgoi.TabIndex = 1;
			this.nmSoChoNgoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 505);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhà hàng";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmSoChoNgoi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgvBanAn;
		private System.Windows.Forms.DataGridView dgvChiTietHD;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cbTrangThaiBanAn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtIDBanAn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtTenBanAn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.NumericUpDown nmSoChoNgoi;
		private System.Windows.Forms.Label label4;
	}
}

