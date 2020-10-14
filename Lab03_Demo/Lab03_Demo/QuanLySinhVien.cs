using System;
using System.Collections.Generic;
using System.IO;

namespace Lab03_Demo
{
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        
        public void Them(SinhVien sinhVien, Action callback)
        {
            var isExists = DanhSach.Exists(sv => sv.MaSo == sinhVien.MaSo);
            if (isExists)
                throw new ArgumentException("Sinh vien co ma: " + sinhVien.MaSo + " da ton tai!");

            DanhSach.Add(sinhVien);
            callback();
        }

        public SinhVien this[int index]
        {
            get
            {
                if (index >= DanhSach.Count)
                    throw new ArgumentOutOfRangeException("Chỉ số vượt quá tổng số phần tử trong danh sách!");

                return DanhSach[index];
            }

            set { DanhSach[index] = value; }
        }

        public void Xoa(SinhVien sv, Action callback)
        {
            if (String.IsNullOrWhiteSpace(sv.MaSo))
                throw new ArgumentException("Vui long nhap ma sinh vien can chinh xoa!");

            var sinhVien = DanhSach.Find(s => s.MaSo == sv.MaSo);
            if (sinhVien is null)
                throw new ArgumentException($"Sinh vien co ma {sv.MaSo} khong ton tai!");

            DanhSach.Remove(sv);
            callback();
        }

        public SinhVien Tim(SinhVien sv) => DanhSach.Find(s => s.MaSo == sv.MaSo);

        public void Sua(SinhVien svCu, SinhVien svMoi)
        {
            if (String.IsNullOrWhiteSpace(svMoi.MaSo))
                throw new ArgumentException("Vui long nhap ma sinh vien can chinh sua!");

            var sinhVienIdx = DanhSach.FindIndex(s => s.MaSo == svCu.MaSo);
            if (sinhVienIdx == -1)
                throw new ArgumentException($"Sinh vien co ma {svCu.MaSo} khong ton tai!");

            DanhSach[sinhVienIdx] = svMoi;
        }

        public void DocTuFile(Action callback)
        {
            string filename = Utils.GetPathTo("Data", "DanhSachSV.txt");
            string temp;

            string[] s;
            SinhVien sv;

            StreamReader reader = new StreamReader(new FileStream(filename, FileMode.Open));

            while ((temp = reader.ReadLine()) != null)
            {
                s = temp.Split('\t');
                sv = new SinhVien();
                sv.MaSo = s[0].Trim();
                sv.HoTen = s[1].Trim();
                sv.NgaySinh = DateTime.Parse(s[2].Trim());
                sv.DiaChi = s[3].Trim();
                sv.Lop = s[4].Trim();
                sv.Hinh = s[5].Trim();
                sv.GioiTinh = s[6].Trim() == "1" ? true : false;
                string[] cn = s[7].Trim().Split(',');
                foreach (var c in cn)
                {
                    sv.ChuyenNganh.Add(c.Trim());
                }
                Them(sv, callback);
            }

            reader.Close();
        }
    }
}
