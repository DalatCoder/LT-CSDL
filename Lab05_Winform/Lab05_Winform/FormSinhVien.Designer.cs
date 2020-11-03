namespace Lab05_Winform
{
	partial class frmNhapThongTinSV
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtMSSV = new System.Windows.Forms.MaskedTextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtSoCMND = new System.Windows.Forms.MaskedTextBox();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.txtSDT = new System.Windows.Forms.MaskedTextBox();
			this.clbMonHocDangKy = new System.Windows.Forms.CheckedListBox();
			this.ctMenuLcbMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuItemThemMonHoc = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemXoaMonHoc = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvDanhSachSV = new System.Windows.Forms.ListView();
			this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTenLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMonHocDK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ctListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuItemXoaSinhVien = new System.Windows.Forms.ToolStripMenuItem();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.btnMacDinh = new System.Windows.Forms.Button();
			this.btnHienThiSV = new System.Windows.Forms.Button();
			this.ctMenuLcbMonHoc.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.ctListViewMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ và tên lót:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày sinh:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số CMND:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Địa chỉ liên lạc:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Môn học đăng ký:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(453, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Giới tính:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(453, 60);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Tên:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(453, 142);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Số ĐT:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(453, 99);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Lớp";
			// 
			// txtMSSV
			// 
			this.txtMSSV.Location = new System.Drawing.Point(149, 19);
			this.txtMSSV.Mask = "0000000";
			this.txtMSSV.Name = "txtMSSV";
			this.txtMSSV.Size = new System.Drawing.Size(209, 20);
			this.txtMSSV.TabIndex = 10;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(149, 57);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(209, 20);
			this.txtHoTen.TabIndex = 11;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(149, 99);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(209, 20);
			this.dtpNgaySinh.TabIndex = 12;
			// 
			// txtSoCMND
			// 
			this.txtSoCMND.Location = new System.Drawing.Point(149, 142);
			this.txtSoCMND.Mask = "000000000";
			this.txtSoCMND.Name = "txtSoCMND";
			this.txtSoCMND.Size = new System.Drawing.Size(209, 20);
			this.txtSoCMND.TabIndex = 13;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Location = new System.Drawing.Point(540, 20);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(47, 17);
			this.rdNam.TabIndex = 15;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(609, 18);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(39, 17);
			this.rdNu.TabIndex = 16;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(540, 60);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(193, 20);
			this.txtTen.TabIndex = 17;
			// 
			// cboLop
			// 
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Items.AddRange(new object[] {
            "CTK38",
            "CTK39",
            "CTK40",
            "CTK41",
            "CTK42",
            "CTK43"});
			this.cboLop.Location = new System.Drawing.Point(540, 96);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(193, 21);
			this.cboLop.TabIndex = 18;
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(540, 139);
			this.txtSDT.Mask = "0000.000.000";
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(193, 20);
			this.txtSDT.TabIndex = 19;
			// 
			// clbMonHocDangKy
			// 
			this.clbMonHocDangKy.CheckOnClick = true;
			this.clbMonHocDangKy.ColumnWidth = 260;
			this.clbMonHocDangKy.ContextMenuStrip = this.ctMenuLcbMonHoc;
			this.clbMonHocDangKy.FormattingEnabled = true;
			this.clbMonHocDangKy.Location = new System.Drawing.Point(145, 216);
			this.clbMonHocDangKy.MultiColumn = true;
			this.clbMonHocDangKy.Name = "clbMonHocDangKy";
			this.clbMonHocDangKy.Size = new System.Drawing.Size(588, 79);
			this.clbMonHocDangKy.TabIndex = 20;
			// 
			// ctMenuLcbMonHoc
			// 
			this.ctMenuLcbMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemThemMonHoc,
            this.menuItemXoaMonHoc});
			this.ctMenuLcbMonHoc.Name = "ctMenuLcbMonHoc";
			this.ctMenuLcbMonHoc.Size = new System.Drawing.Size(199, 48);
			// 
			// menuItemThemMonHoc
			// 
			this.menuItemThemMonHoc.Name = "menuItemThemMonHoc";
			this.menuItemThemMonHoc.Size = new System.Drawing.Size(198, 22);
			this.menuItemThemMonHoc.Text = "Thêm môn học";
			this.menuItemThemMonHoc.Click += new System.EventHandler(this.menuItemThemMonHoc_Click);
			// 
			// menuItemXoaMonHoc
			// 
			this.menuItemXoaMonHoc.Name = "menuItemXoaMonHoc";
			this.menuItemXoaMonHoc.Size = new System.Drawing.Size(198, 22);
			this.menuItemXoaMonHoc.Text = "Xóa môn học đánh dấu";
			this.menuItemXoaMonHoc.Click += new System.EventHandler(this.menuItemXoaMonHoc_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(246, 312);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 21;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(353, 312);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 22;
			this.btnThem.Text = "Thêm mới";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(456, 312);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
			this.btnCapNhat.TabIndex = 23;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(658, 312);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 24;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lvDanhSachSV);
			this.groupBox1.Location = new System.Drawing.Point(30, 352);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(706, 347);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách sinh viên";
			// 
			// lvDanhSachSV
			// 
			this.lvDanhSachSV.CheckBoxes = true;
			this.lvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colTenLot,
            this.colTen,
            this.colNgaySinh,
            this.colLop,
            this.colCMND,
            this.colSDT,
            this.colDiaChi,
            this.colGioiTinh,
            this.colMonHocDK});
			this.lvDanhSachSV.ContextMenuStrip = this.ctListViewMenu;
			this.lvDanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvDanhSachSV.FullRowSelect = true;
			this.lvDanhSachSV.GridLines = true;
			this.lvDanhSachSV.Location = new System.Drawing.Point(3, 16);
			this.lvDanhSachSV.Name = "lvDanhSachSV";
			this.lvDanhSachSV.Size = new System.Drawing.Size(700, 328);
			this.lvDanhSachSV.TabIndex = 0;
			this.lvDanhSachSV.UseCompatibleStateImageBehavior = false;
			this.lvDanhSachSV.View = System.Windows.Forms.View.Details;
			this.lvDanhSachSV.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachSV_SelectedIndexChanged);
			// 
			// colMSSV
			// 
			this.colMSSV.Text = "MSSV";
			this.colMSSV.Width = 70;
			// 
			// colTenLot
			// 
			this.colTenLot.Text = "Họ và tên lót";
			this.colTenLot.Width = 150;
			// 
			// colTen
			// 
			this.colTen.Text = "Tên";
			// 
			// colNgaySinh
			// 
			this.colNgaySinh.Text = "Ngày sinh";
			this.colNgaySinh.Width = 120;
			// 
			// colLop
			// 
			this.colLop.Text = "Lớp";
			// 
			// colCMND
			// 
			this.colCMND.Text = "Số CMND";
			// 
			// colSDT
			// 
			this.colSDT.Text = "Số điện thoại";
			// 
			// colDiaChi
			// 
			this.colDiaChi.Text = "Địa chỉ liên lạc";
			this.colDiaChi.Width = 180;
			// 
			// colGioiTinh
			// 
			this.colGioiTinh.Text = "Giới tính";
			// 
			// colMonHocDK
			// 
			this.colMonHocDK.Text = "Môn học đăng ký";
			this.colMonHocDK.Width = 200;
			// 
			// ctListViewMenu
			// 
			this.ctListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemXoaSinhVien});
			this.ctListViewMenu.Name = "ctListViewMenu";
			this.ctListViewMenu.Size = new System.Drawing.Size(214, 26);
			// 
			// menuItemXoaSinhVien
			// 
			this.menuItemXoaSinhVien.Name = "menuItemXoaSinhVien";
			this.menuItemXoaSinhVien.Size = new System.Drawing.Size(213, 22);
			this.menuItemXoaSinhVien.Text = "Xóa sinh viên đã đánh dấu";
			this.menuItemXoaSinhVien.Click += new System.EventHandler(this.menuItemXoaSinhVien_Click);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(148, 180);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(585, 20);
			this.txtDiaChi.TabIndex = 26;
			// 
			// btnMacDinh
			// 
			this.btnMacDinh.Location = new System.Drawing.Point(562, 312);
			this.btnMacDinh.Name = "btnMacDinh";
			this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
			this.btnMacDinh.TabIndex = 27;
			this.btnMacDinh.Text = "Mặc định";
			this.btnMacDinh.UseVisualStyleBackColor = true;
			this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
			// 
			// btnHienThiSV
			// 
			this.btnHienThiSV.Location = new System.Drawing.Point(145, 312);
			this.btnHienThiSV.Name = "btnHienThiSV";
			this.btnHienThiSV.Size = new System.Drawing.Size(75, 23);
			this.btnHienThiSV.TabIndex = 28;
			this.btnHienThiSV.Text = "Tất cả SV";
			this.btnHienThiSV.UseVisualStyleBackColor = true;
			this.btnHienThiSV.Click += new System.EventHandler(this.btnHienThiSV_Click);
			// 
			// frmNhapThongTinSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 711);
			this.Controls.Add(this.btnHienThiSV);
			this.Controls.Add(this.btnMacDinh);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.clbMonHocDangKy);
			this.Controls.Add(this.txtSDT);
			this.Controls.Add(this.cboLop);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.txtSoCMND);
			this.Controls.Add(this.dtpNgaySinh);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.txtMSSV);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmNhapThongTinSV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập thông tin sinh viên";
			this.Load += new System.EventHandler(this.frmNhapThongTinSV_Load);
			this.ctMenuLcbMonHoc.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ctListViewMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MaskedTextBox txtMSSV;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.MaskedTextBox txtSoCMND;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.ComboBox cboLop;
		private System.Windows.Forms.MaskedTextBox txtSDT;
		private System.Windows.Forms.CheckedListBox clbMonHocDangKy;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvDanhSachSV;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.ColumnHeader colMSSV;
		private System.Windows.Forms.ColumnHeader colTenLot;
		private System.Windows.Forms.ColumnHeader colTen;
		private System.Windows.Forms.ColumnHeader colNgaySinh;
		private System.Windows.Forms.ColumnHeader colLop;
		private System.Windows.Forms.ColumnHeader colCMND;
		private System.Windows.Forms.ColumnHeader colSDT;
		private System.Windows.Forms.ColumnHeader colDiaChi;
		private System.Windows.Forms.ColumnHeader colGioiTinh;
		private System.Windows.Forms.ColumnHeader colMonHocDK;
		private System.Windows.Forms.ContextMenuStrip ctListViewMenu;
		private System.Windows.Forms.ToolStripMenuItem menuItemXoaSinhVien;
		private System.Windows.Forms.ContextMenuStrip ctMenuLcbMonHoc;
		private System.Windows.Forms.ToolStripMenuItem menuItemThemMonHoc;
		private System.Windows.Forms.ToolStripMenuItem menuItemXoaMonHoc;
		private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.Button btnHienThiSV;
	}
}

