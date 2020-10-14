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
    public class SinhVienSortNgaySinh : IComparer<SinhVien>
    {
        public int Compare(SinhVien x, SinhVien y)
        {
            return x.NgaySinh.CompareTo(y.NgaySinh);
        }
    }

    public class SinhVienSortMaSo : IComparer<SinhVien>
    {
        public int Compare(SinhVien x, SinhVien y)
        {
            return int.Parse(x.MaSo) - int.Parse(y.MaSo);
        }
    }

    public class SinhVienSortHoTen : IComparer<SinhVien>
    {
        public int Compare(SinhVien x, SinhVien y)
        {
            var firstWords = x.HoTen.Split(' ');
            var secondWords = y.HoTen.Split(' ');

            var firstName = firstWords[firstWords.Length - 1];
            var secondName = secondWords[secondWords.Length - 1];

            return firstName.CompareTo(secondName);
        }
    }

    public partial class frmTuyChon : Form
    {
        QuanLySinhVien qlsv;
        ListView listView;

        public frmTuyChon()
        {
            InitializeComponent();
        }

        public frmTuyChon(QuanLySinhVien qlsv, ListView listView, string loai)
        {
            InitializeComponent();
            this.qlsv = qlsv;
            this.listView = listView;

            if (loai == "search")
            {
                btnSapXep.Enabled = false;
            }
            else if (loai == "sort")
            {
                label1.Enabled = false;
                txtTimKiem.Enabled = false;
                btnTimKiem.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SinhVien sv = null;

            if (rdMaSV.Checked)
                sv = qlsv.DanhSach.Find(s => s.MaSo.Trim() == txtTimKiem.Text.Trim());
            else if (rdHoTen.Checked)
                sv = qlsv.DanhSach.Find(s => s.HoTen.Contains(txtTimKiem.Text.Trim()));
            else if (rdNgaySinh.Checked)
                sv = qlsv.DanhSach.Find(s => s.NgaySinh.Day == int.Parse(txtTimKiem.Text));

            if (sv is null)
            {
                MessageBox.Show("Khong tim thay sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Close();

            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
            item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
            item.SubItems.Add(sv.Hinh);

            listView.Items.Clear();
            listView.Items.Add(item);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (rdNgaySinh.Checked)
            {
                 qlsv.DanhSach.Sort(new SinhVienSortNgaySinh());
            }
            else if (rdHoTen.Checked)
            {
                qlsv.DanhSach.Sort(new SinhVienSortHoTen());
            }
            else if (rdMaSV.Checked)
            {
                qlsv.DanhSach.Sort(new SinhVienSortMaSo());
            }

            listView.Items.Clear();
            foreach (var sv in qlsv.DanhSach)
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
                item.SubItems.Add(sv.Hinh);

                listView.Items.Add(item);
            }

            this.Close();
        }
    }
}
