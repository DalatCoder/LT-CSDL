using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Page60_Buoi3
{
    public partial class frmNhanVien : Form
    {
        List<NhanVien> ListMain = new List<NhanVien>();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nhanVien = GetNhanVien();
            ListMain.Add(nhanVien);
            AddListView();
        }

        private NhanVien GetNhanVien()
        {
            string maNV = this.mtbMaNV.Text;
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string hoTen = this.txtName.Text;
            DateTime ngaySinh = this.dtpNgaySinh.Value;
            string soDT = this.mtbSoDT.Text;
            string diaChi = txtAddress.Text;
            string phongBan = cboPhongBan.Text;
            string email = txtMail.Text;
            string hinh = txtHinh.Text;

            return new NhanVien(maNV, hoTen, ngaySinh, gioiTinh, soDT, diaChi, phongBan, email, hinh);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            AddListView();
        }

        private void ClearListView()
        {
            listView1.Items.Clear(); 
        }

        private void AddListView()
        {

            ClearListView();

            foreach (var item in ListMain)
            {
                ListViewItem row = listView1.Items.Add(item.MaNV);

                row.SubItems.Add(item.TenNV);
                row.SubItems.Add(item.NgaySinh.ToString("dd/MM/yyyy"));
                row.SubItems.Add(item.GioiTinh);
                row.SubItems.Add(item.DiaChi);
                row.SubItems.Add(item.Email);
                row.SubItems.Add(item.SoDT);
                row.SubItems.Add(item.PhongBan);
                row.SubItems.Add(item.Hinh);
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void Reset()
        {
            this.mtbMaNV.Text = "";
            this.rdNam.Checked = true;
            this.txtName.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.mtbSoDT.Text = "";
            this.txtAddress.Text = "";
            this.cboPhongBan.Text = "";
            this.txtMail.Text = "";
            this.txtHinh.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListMain.Clear();
            AddListView();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG file|.jpg|All file|*.*";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtHinh.Text = op.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }
    }
}
