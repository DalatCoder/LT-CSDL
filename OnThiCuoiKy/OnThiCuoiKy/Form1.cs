using OnThiCuoiKy.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiCuoiKy
{
	public partial class frmMain : Form
	{
		BindingSource banAnSource = new BindingSource();

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			BanAnDAO banAnDAO = new BanAnDAO();
			dgvBanAn.DataSource = banAnSource;

			banAnSource.DataSource = banAnDAO.LayDSBanAn();

			AddBindingSourceBanAn();
		}

		private void AddBindingSourceBanAn()
		{
			txtIDBanAn.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "ID"));
			txtTenBanAn.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Name"));
			nmSoChoNgoi.DataBindings.Add(new Binding("Value", dgvBanAn.DataSource, "Capacity"));
			cbTrangThaiBanAn.DataBindings.Add(new Binding("SelectedIndex", dgvBanAn.DataSource, "Status"));
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string tenBanAn = txtTenBanAn.Text;
			int soChoNgoi = Convert.ToInt32(nmSoChoNgoi.Value);
			int trangThai = 0;

			if (cbTrangThaiBanAn.SelectedItem.ToString() == "Có người")
				trangThai = 1;

			// Kiểm tra giá trị người dùng nhập
			BanAnDAO banAnDAO = new BanAnDAO();
			bool thanhCong = banAnDAO.TaoBanAn(tenBanAn, trangThai, soChoNgoi);

			if (thanhCong == false)
			{
				MessageBox.Show("Có lỗi trong quá trình thêm bàn ăn mới, thử lại sau", "Thông báo lỗi");
				return;
			}

			MessageBox.Show("Thêm bàn ăn mới thành công", "Thông báo");
			dgvBanAn.DataSource = banAnDAO.LayDSBanAn();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtIDBanAn.Text);
			string tenBanAn = txtTenBanAn.Text;
			int soChoNgoi = Convert.ToInt32(nmSoChoNgoi.Value);
			int trangThai = 0;

			if (cbTrangThaiBanAn.SelectedItem.ToString() == "Có người")
				trangThai = 1;

			BanAnDAO banAnDAO = new BanAnDAO();
			bool capNhatThanhCong = banAnDAO.CapNhatBanAn(id, tenBanAn, trangThai, soChoNgoi);

			if (capNhatThanhCong == false)
			{
				MessageBox.Show("Có lỗi trong quá trình cập nhât bàn ăn, thử lại sau", "Thông báo lỗi");
				return;
			}

			MessageBox.Show("Cập nhật bàn ăn thành công", "Thông báo");
			dgvBanAn.DataSource = banAnDAO.LayDSBanAn();
		}

		private void dgvBanAn_Click(object sender, EventArgs e)
		{
			if (dgvBanAn.SelectedRows.Count == 0) return;

			int tableId = Convert.ToInt32(dgvBanAn.SelectedRows[0].Cells["ID"].Value.ToString());

			ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
			dgvChiTietHD.DataSource = chiTietHoaDonDAO.LayChiTietHoaDonTheoBan(tableId);
		}
	}
}
