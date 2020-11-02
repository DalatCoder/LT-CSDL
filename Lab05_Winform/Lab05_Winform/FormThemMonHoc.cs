using System;
using System.Windows.Forms;

namespace Lab05_Winform
{
	public partial class frmThemMonHoc : Form
	{
		public string TenMonHoc { get; set; }

		public frmThemMonHoc()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				string tenMonHoc = txtTenMH.Text;
				StringValidator.CheckRequire(tenMonHoc, "Tên môn học không hợp lệ");

				TenMonHoc = tenMonHoc;
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
