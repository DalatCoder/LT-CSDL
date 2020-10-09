using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            quanLySV.DocTuFile();
            RenderListView();
        }

        private SinhVien GetSinhVien()
        {
            bool gioiTinh = rdNam.Checked ? true : false;
            string maSo = mtxtMaSo.Text.Split('.')[1];
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemSelectedCount = listView1.SelectedItems.Count;
            if (itemSelectedCount > 0)
            {
                ListViewItem itemSelected = listView1.SelectedItems[0];
                ThietLapThongTin(GetSinhVienOnListViewItem(itemSelected));
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();

            try
            {
                quanLySV.Them(sv);
                RenderListView();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                if (item.Checked) 
                    quanLySV.Xoa(GetSinhVienOnListViewItem(item));

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
            SinhVien svMoi = GetSinhVien();

            try
            {
                quanLySV.Sua(new SinhVien { MaSo = svMoi.MaSo }, svMoi);
                RenderListView();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
