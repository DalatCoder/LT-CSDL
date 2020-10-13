using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab03_Demo
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien quanLySV;
        public frmSinhVien()
        {
            InitializeComponent();
            quanLySV = new QuanLySinhVien();
            quanLySV.DocTuFile(renderStatusBar);
            RenderListView();
        }

        private SinhVien GetSinhVien()
        {
            bool gioiTinh = rdNam.Checked ? true : false;
            string maSo = mtxtMaSo.Text.Split('.')[1];

            if (maSo.Trim().Length != 7)
                throw new ArgumentException("Vui long nhap ma sinh vien hop le");

            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string lop = cboLop.Text;
            string hinh = txtHinh.Text;

            List<string> chuyenNganh = new List<string>();  
            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                if (clbChuyenNganh.GetItemChecked(i))
                    chuyenNganh.Add(clbChuyenNganh.Items[i].ToString());

            return new SinhVien(maSo, hoTen, ngaySinh, diaChi, lop, hinh, gioiTinh, chuyenNganh);
        }

        private SinhVien GetSinhVienOnListViewItem(ListViewItem item)
        {
            string maSo = item.SubItems[0].Text;
            return quanLySV.Tim(new SinhVien { MaSo = maSo });
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            mtxtMaSo.Text = sv.MaSo;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            txtDiaChi.Text = sv.DiaChi;
            cboLop.Text = sv.Lop;
            txtHinh.Text = sv.Hinh;
            pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh) rdNam.Checked = true;
            else rdNu.Checked = true;

            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                clbChuyenNganh.SetItemChecked(i, false);

            foreach (var chuyenNganh in sv.ChuyenNganh)
            {
                for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                    if (chuyenNganh.CompareTo(clbChuyenNganh.Items[i]) == 0)
                        clbChuyenNganh.SetItemChecked(i, true);
            }       
        }

        private void renderStatusBar()
        {
            sttLabelTongSinhVien.Text = "Tổng Số Sinh Viên: " + quanLySV.DanhSach.Count;
        }

        private void RenderListViewItem(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
            item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
            item.SubItems.Add(sv.Hinh);

            listView1.Items.Add(item);
        }

        private void RenderListView()
        {
            listView1.Items.Clear();
            quanLySV.DanhSach.ForEach(sv => RenderListViewItem(sv));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = GetSinhVien();
                quanLySV.Them(sv, renderStatusBar);
                RenderListView();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
                MessageBox.Show("Vui long chon sinh vien de xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (ListViewItem item in listView1.Items)
                if (item.Checked) 
                    quanLySV.Xoa(GetSinhVienOnListViewItem(item), renderStatusBar);

            RenderListView();
            btnMacDinh.PerformClick();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            mtxtMaSo.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            cboLop.Text = cboLop.Items[0].ToString();
            txtHinh.Text = "";
            pbHinh.ImageLocation = "";
            rdNam.Checked = true;

            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien svMoi = GetSinhVien();
                quanLySV.Sua(new SinhVien { MaSo = svMoi.MaSo }, svMoi);
                RenderListView();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = pictureDialog;

            bool isAccept = fileDialog.ShowDialog() == DialogResult.OK;
            if (isAccept)
            {
                var arr = fileDialog.FileName.Split('\\');
                string fileName = arr[arr.Length - 1].Split('.')[0];
                string extension = arr[arr.Length - 1].Split('.')[1];

                // Make unique file name
                fileName += "_" + DateTime.UtcNow.ToBinary();

                string fullFileName = fileName + "." + extension;

                string projectPath = Utils.GetPathTo("data", "photos", fullFileName);

                // Copy file to /data in project folder
                File.Copy(fileDialog.FileName, projectPath);

                txtHinh.Text = projectPath;
                pbHinh.ImageLocation = projectPath;
            }
        }

        private void menuItemOpenFile_Click(object sender, EventArgs e)
        {
            btnBrowse.PerformClick();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            btnThoat.PerformClick();
        }

        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void menuItemEdit_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void menuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = fontDialog1;
            var isOK = fontDialog.ShowDialog();

            if (isOK == DialogResult.OK)
            {
                listView1.Font = fontDialog.Font;
            }
        }

        private void menuItemFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var isOK = colorDialog.ShowDialog();

            if(isOK == DialogResult.OK)
            {
                listView1.ForeColor = colorDialog.Color;
            }
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            var formTuyChon = new frmTuyChon(quanLySV, listView1 , "search");
            formTuyChon.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var sinhVien = GetSinhVienOnListViewItem(listView1.SelectedItems[0]);
            ThietLapThongTin(sinhVien);
        }

        private void menuItemSort_Click(object sender, EventArgs e)
        {
            var formTuyChon = new frmTuyChon(quanLySV, listView1, "sort");
            formTuyChon.ShowDialog();
        }
    }
}
