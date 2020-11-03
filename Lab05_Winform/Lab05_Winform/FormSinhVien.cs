using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Lab05_Winform
{
	public partial class frmNhapThongTinSV : Form
	{
		private readonly QLSinhVien qlSinhVien;
		private readonly List<string> dsMonHocDangKy;

		public frmNhapThongTinSV()
		{
			InitializeComponent();

			string txtFilePath = Utils.GetPathTo("DanhSachSV.txt");
			string jsonFilePath = Utils.GetPathTo("DanhSachSV.json");

			// qlSinhVien = new QLSinhVien(new FileDataStorage(filePath));
			qlSinhVien = new QLSinhVien(new JSONDataStorage(jsonFilePath));

			dsMonHocDangKy = new List<string>
			{
				"Mạng máy tính",
				"Hệ điều hành",
				"Lập trình CSDL",
				"Lập trình mạng",
				"Đồ án cơ sở",
				"Phương pháp NCKH",
				"Lập trình trên thiết bị di động",
				"An toàn và bảo mật hệ thống"
			};
		}

		private void frmNhapThongTinSV_Load(object sender, EventArgs e)
		{
			RenderDanhSachMonHoc(dsMonHocDangKy);
			RenderListView(qlSinhVien.GetAll());
		}

		public SinhVien GetSinhVien()
		{
			string mssv = txtMSSV.Text;
			StringValidator.CheckRequire(mssv, "Mã số sinh viên không hợp lệ");
			StringValidator.CheckLengthEqualTo(mssv, 7, "Mã số sinh viên phải đủ 7 kí tự");

			string tenLot = txtHoTen.Text;
			StringValidator.CheckRequire(tenLot, "Tên lót không hợp lệ");

			DateTime ngaySinh = dtpNgaySinh.Value;

			string cmnd = txtSoCMND.Text;
			StringValidator.CheckRequire(cmnd, "Chứng minh nhân dân không hợp lệ");
			StringValidator.CheckLengthEqualTo(cmnd, 9, "Chứng minh phải đủ 9 kí tự");

			GioiTinh gioiTinh = rdNam.Checked ? GioiTinh.NAM : GioiTinh.NU;

			string ten = txtTen.Text;
			StringValidator.CheckRequire(ten, "Tên không hợp lệ");

			string lop = cboLop.Text;
			StringValidator.CheckRequire(lop, "Lớp không hợp lệ");

			string soDT = txtSDT.Text;
			StringValidator.CheckRequire(soDT, "Số điện thoại không hợp lệ");
			StringValidator.CheckLengthEqualTo(soDT, 10, "Số điện thoại phải đủ 11 kí tự");

			string diaChi = txtDiaChi.Text;
			StringValidator.CheckRequire(diaChi, "Địa chỉ không hợp lệ");

			List<String> dsMonHoc = new List<string>();
			foreach (var item in clbMonHocDangKy.CheckedItems)
				dsMonHoc.Add(item as string);

			return new SinhVien(mssv, tenLot, cmnd, gioiTinh, ngaySinh, diaChi, ten, lop, soDT, dsMonHoc);
		}

		public SinhVien GetSinhVienFromListViewItem(ListViewItem lvItem)
		{
			string mssv = lvItem.SubItems[0].Text;
			string tenLot = lvItem.SubItems[1].Text;
			string ten = lvItem.SubItems[2].Text;
			string ngaySinhStr = lvItem.SubItems[3].Text;
			DateTime ngaySinh = DateTime.ParseExact(ngaySinhStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
			string lop = lvItem.SubItems[4].Text;
			string cmnd = lvItem.SubItems[5].Text;
			string sdt = lvItem.SubItems[6].Text;
			string diaChi = lvItem.SubItems[7].Text;
			GioiTinh gioiTinh = lvItem.SubItems[8].Text == "Nam" ? GioiTinh.NAM : GioiTinh.NU;

			string[] stringSeperator = new string[] { ", " };
			string[] dsMonHoc = lvItem.SubItems[9].Text.Split(stringSeperator, StringSplitOptions.None);
			List<string> monHoc = new List<string>(dsMonHoc);

			return new SinhVien(mssv, tenLot, cmnd, gioiTinh, ngaySinh, diaChi, ten, lop, sdt, monHoc);
		}

		public void RenderSinhVien(SinhVien sv)
		{
			txtMSSV.Text = sv.MSSV;
			txtMSSV.Enabled = false;

			txtHoTen.Text = sv.TenLot;
			dtpNgaySinh.Value = sv.NgaySinh;
			txtSoCMND.Text = sv.SoCMND;

			dtpNgaySinh.Value = sv.NgaySinh;

			rdNam.Checked = false;
			rdNam.Checked = false;
			if (sv.gioiTinh == GioiTinh.NAM)
				rdNam.Checked = true;
			else
				rdNu.Checked = true;

			txtTen.Text = sv.Ten;
			cboLop.Text = sv.Lop;
			txtSDT.Text = sv.SDT;
			txtDiaChi.Text = sv.DiaChi;

			for (int i = 0; i < clbMonHocDangKy.Items.Count; i++)
			{
				clbMonHocDangKy.SetItemChecked(i, false);
			}

			foreach (var monHoc in sv.dsMonHocDangKy)
			{
				for(int i = 0; i < clbMonHocDangKy.Items.Count; i++)
				{					
					if (clbMonHocDangKy.Items[i].ToString() == monHoc)
						clbMonHocDangKy.SetItemChecked(i, true);
				}
			}
		}

		public void ClearForm()
		{
			txtMSSV.Text = "";
			txtMSSV.Enabled = true;

			txtDiaChi.Text = "";
			txtHoTen.Text = "";
			txtSDT.Text = "";
			txtSoCMND.Text = "";
			txtTen.Text = "";
			cboLop.Text = "";
			dtpNgaySinh.Value = DateTime.Now;

			rdNam.Checked = false;
			rdNu.Checked = false;

			for (int i = 0; i < clbMonHocDangKy.Items.Count; i++)
				clbMonHocDangKy.SetItemChecked(i, false);
		}

		public ListViewItem createListViewItem(SinhVien sinhVien)
		{
			ListViewItem listViewItem = new ListViewItem(sinhVien.MSSV);
			listViewItem.SubItems.Add(sinhVien.TenLot);
			listViewItem.SubItems.Add(sinhVien.Ten);
			listViewItem.SubItems.Add(sinhVien.NgaySinh.ToString("dd/MM/yyyy"));
			listViewItem.SubItems.Add(sinhVien.Lop);
			listViewItem.SubItems.Add(sinhVien.SoCMND);
			listViewItem.SubItems.Add(sinhVien.SDT);
			listViewItem.SubItems.Add(sinhVien.DiaChi);
			listViewItem.SubItems.Add(sinhVien.gioiTinh == GioiTinh.NAM ? "Nam" : "Nữ");
			listViewItem.SubItems.Add(string.Join(", ", sinhVien.dsMonHocDangKy));

			return listViewItem;
		}

		public void RenderListView(List<SinhVien> dsSinhVien)
		{
			lvDanhSachSV.Items.Clear();
			foreach (var sinhVien in dsSinhVien)
				lvDanhSachSV.Items.Add(createListViewItem(sinhVien));
		}

		public void RenderDanhSachMonHoc(List<string> dsMonHocDangKy)
		{
			foreach (var monHoc in dsMonHocDangKy)
				clbMonHocDangKy.Items.Add(monHoc, false);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
				Application.Exit();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				SinhVien sinhVien = GetSinhVien();
				qlSinhVien.Add(sinhVien);
				RenderListView(qlSinhVien.GetAll());
				ClearForm();
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			ClearForm();

			frmTimKiem frm = new frmTimKiem();
		 	DialogResult result = frm.ShowDialog();

			if (result != DialogResult.OK) return;

			string mssv = frm.MSSV;
			string ten = frm.Ten;
			string lop = frm.Lop;

			if (!string.IsNullOrWhiteSpace(mssv))
			{
				var sinhVien = qlSinhVien.GetByID(mssv);
				if (sinhVien is null)
				{
					MessageBox.Show($"Không tìm thấy sinh viên có mã số: {mssv}.");
					return;
				}

				ListViewItem listViewItem = createListViewItem(sinhVien);
				lvDanhSachSV.Items.Clear();
				lvDanhSachSV.Items.Add(listViewItem);
				return;
			}

			List<SinhVien> danhSachKetQua = new List<SinhVien>();
			if (!string.IsNullOrWhiteSpace(ten))
			{
				danhSachKetQua = qlSinhVien.GetByName(ten);
			}

			if (!string.IsNullOrWhiteSpace(lop))
			{
				danhSachKetQua = qlSinhVien.GetByClassName(lop);
			}

			if (danhSachKetQua.Count == 0)
			{
				MessageBox.Show("Không tìm thấy sinh viên.");
				return;
			}

			RenderListView(danhSachKetQua);
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			try
			{
				SinhVien sinhVien = GetSinhVien();
				qlSinhVien.UpdateByID(sinhVien.MSSV, sinhVien);
				RenderListView(qlSinhVien.GetAll());
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvDanhSachSV.SelectedItems.Count == 0) return;

			SinhVien sinhVien = GetSinhVienFromListViewItem(lvDanhSachSV.SelectedItems[0]);
			RenderSinhVien(sinhVien);
		}

		private void menuItemXoaSinhVien_Click(object sender, EventArgs e)
		{
			if (lvDanhSachSV.CheckedIndices.Count == 0)
			{
				MessageBox.Show("Đánh dấu sinh viên cần xóa");
				return;
			}

			foreach (ListViewItem item in lvDanhSachSV.CheckedItems)
			{
				SinhVien sv = GetSinhVienFromListViewItem(item);
				qlSinhVien.DeleteByID(sv.MSSV);
			}

			ClearForm();
			RenderListView(qlSinhVien.GetAll());
		}

		private void menuItemThemMonHoc_Click(object sender, EventArgs e)
		{
			var formThemMonHoc = new frmThemMonHoc();
			var result = formThemMonHoc.ShowDialog();
			
			if (result == DialogResult.OK)
			{
				string tenMonHocMoi = formThemMonHoc.TenMonHoc;

				if (dsMonHocDangKy.Exists(mh => mh == tenMonHocMoi))
				{
					MessageBox.Show("Môn học đã tồn tại");
					return;
				}

				dsMonHocDangKy.Add(tenMonHocMoi);
				clbMonHocDangKy.Items.Clear();
				foreach (var monHoc in dsMonHocDangKy)
					clbMonHocDangKy.Items.Add(monHoc, false);
			}
		}

		private void menuItemXoaMonHoc_Click(object sender, EventArgs e)
		{
			if (clbMonHocDangKy.Items.Count == 0)
			{
				MessageBox.Show("Không có môn học để xóa");
				return;
			}	

			if (clbMonHocDangKy.CheckedItems.Count == 0)
			{
				MessageBox.Show("Chọn môn học để xóa");
				return;
			}		

			foreach (var monHoc in clbMonHocDangKy.CheckedItems)
				dsMonHocDangKy.Remove(monHoc as string);

			clbMonHocDangKy.Items.Clear();
			foreach (var monHoc in dsMonHocDangKy)
				clbMonHocDangKy.Items.Add(monHoc, false);
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void btnHienThiSV_Click(object sender, EventArgs e)
		{
			ClearForm();
			RenderListView(qlSinhVien.GetAll());
		}
	}
}
