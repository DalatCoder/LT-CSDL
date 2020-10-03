using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab02_GiaoVien
{
    public partial class frmGiaoVien : Form
    {
        private QuanLyGiaoVien quanLyGV;

        public frmGiaoVien()
        {
            InitializeComponent();
            quanLyGV = new QuanLyGiaoVien();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            cboMaSo.SelectedItem = cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int idx = lbDanhSachMH.SelectedItems.Count - 1;
            while (idx >= 0)
            {
                lbMoncHocDay.Items.Add(lbDanhSachMH.SelectedItems[idx]);
                lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[idx]);
                idx--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idx = lbMoncHocDay.SelectedItems.Count - 1;
            while (idx >= 0)
            {
                lbDanhSachMH.Items.Add(lbMoncHocDay.SelectedItems[idx]);
                lbMoncHocDay.Items.Remove(lbMoncHocDay.SelectedItems[idx]);
                idx--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            cboMaSo.Text = "";
            txtHoTen.Text = "";
            txtMail.Text = "";
            mtxtSoDT.Text = "";
            rdNam.Checked = true;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }

            foreach (var monHoc in lbMoncHocDay.Items)
            {
                lbDanhSachMH.Items.Add(monHoc);
            }
            lbMoncHocDay.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = e.Link.LinkData.ToString();
            Process.Start(link);    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var frmTBGiaoVien = new frmTBGiaoVien();
            frmTBGiaoVien.SetText(GetGiaoVien().ToString());
            frmTBGiaoVien.ShowDialog();
        }

        public GiaoVien GetGiaoVien()
        {
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string maSo = cboMaSo.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string mail = txtMail.Text;
            string rawSoDT = mtxtSoDT.Text;
            rawSoDT = rawSoDT.Replace(".", "");
            rawSoDT = rawSoDT.Replace("(", "");
            rawSoDT = rawSoDT.Replace(")", "");
            string soDT = rawSoDT;

            List<string> languages = new List<string>();
            for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                    languages.Add(chklbNgoaiNgu.Items[i].ToString());
            }

            DanhMucMonHoc dsMonHoc = new DanhMucMonHoc();
            foreach (var monHoc in lbMoncHocDay.Items)
            {
                dsMonHoc.Them(new MonHoc(monHoc.ToString()));
            }

            return new GiaoVien(maSo, hoTen, ngaySinh, dsMonHoc, gioiTinh, languages, soDT, mail);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var frmTimKiem = new frmTimKiem(quanLyGV);
            frmTimKiem.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var giaoVien = GetGiaoVien();

            var success = quanLyGV.Them(giaoVien);
            if (!success) 
                MessageBox.Show("Giáo viên có mã số " + giaoVien.MaSo + " đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
