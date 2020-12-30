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
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			BanAnDAO banAnDAO = new BanAnDAO();
			dgvBanAn.DataSource = banAnDAO.LayDSBanAn();
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
	}
}
