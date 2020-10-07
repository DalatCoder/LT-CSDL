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
            var isExist = ListMain.Exists(nv => nv.MaNV == nhanVien.MaNV);
            if (isExist)
            {
                string msg = "Nhân viên có mã số: " + nhanVien.MaNV + " đã tồn tại!";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListMain.Add(nhanVien);
            AddListView();
            this.Reset();
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
            this.pictureBox1.Image = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListMain.Clear();
            AddListView();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG file|*.jpg|All file|*.*";

            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtHinh.Text = op.FileName;
                pictureBox1.ImageLocation = op.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                string msg = "Hãy nhọn 1 nhân viên để sửa thông tin";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";

                var selectedItem = listView1.SelectedItems[0];

                //row.SubItems.Add(item.TenNV);
                //row.SubItems.Add(item.NgaySinh.ToString("dd/MM/yyyy"));
                //row.SubItems.Add(item.GioiTinh);
                //row.SubItems.Add(item.DiaChi);
                //row.SubItems.Add(item.Email);
                //row.SubItems.Add(item.SoDT);
                //row.SubItems.Add(item.PhongBan);
                //row.SubItems.Add(item.Hinh);

                // Trích xuất thông tin của nhân viên được chọn theo thứ tự đã chèn trước đó
                string maNV = selectedItem.SubItems[0].Text;
                string tenNV = selectedItem.SubItems[1].Text;
                string[] ngaySinhArr = selectedItem.SubItems[2].Text.Split('/');
                string gioiTinh = selectedItem.SubItems[3].Text;
                string diaChi = selectedItem.SubItems[4].Text;
                string email = selectedItem.SubItems[5].Text;
                string soDT = selectedItem.SubItems[6].Text;
                string phongBan = selectedItem.SubItems[7].Text;
                string hinh = selectedItem.SubItems[8].Text;

                DateTime ngaySinh = new DateTime(int.Parse(ngaySinhArr[2]), int.Parse(ngaySinhArr[1]), int.Parse(ngaySinhArr[0]));

                // Chèn thông tin đã lưu trữ vào giao diện để người dùng chỉnh sửa
                // Không cho thay đổi lại mã nhân viên
                mtbMaNV.Text = maNV;
                mtbMaNV.ReadOnly = true;

                txtName.Text = tenNV;
                if (gioiTinh == "Nam") rdNam.Checked = true;
                else rdNu.Checked = true;
                dtpNgaySinh.Value = ngaySinh;
                txtAddress.Text = diaChi;
                txtMail.Text = email;
                txtHinh.Text = hinh;
                pictureBox1.ImageLocation = hinh;
                cboPhongBan.Text = phongBan;
                mtbSoDT.Text = soDT;
            }    

            else if (btnSua.Text == "Lưu")
            {
                // Lấy thông tin mới của nhân viên
                var newNhanVien = GetNhanVien();

                // Xóa thông tin cũ của nhân viên
                var oldNhanVienIdx = ListMain.FindIndex(nv => nv.MaNV == newNhanVien.MaNV);
                ListMain.RemoveAt(oldNhanVienIdx);

                // Thêm thông tin nhân viên mới vào
                ListMain.Insert(oldNhanVienIdx, newNhanVien);

                // Hiển thị lại danh sách nhân viên
                AddListView();

                btnSua.Text = "Sửa";
                mtbMaNV.ReadOnly = false;
            }
        }
    }
}
