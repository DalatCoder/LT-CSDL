using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab02_GiaoVien
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public List<string> NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new List<string>();
        }
        public GiaoVien
            (
                string maSo, string hoTen, 
                DateTime ngaySinh, DanhMucMonHoc ds, 
                string gioiTinh, List<string> ngoaiNgu, 
                string sdt, string mail
            )
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            dsMonHoc = ds;
            GioiTinh = gioiTinh;
            NgoaiNgu = ngoaiNgu;
            SoDT = sdt;    
            Mail = mail;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder("");

            if (MaSo.Trim().Length > 0) str.AppendLine("Mã số: " + MaSo);
            if (HoTen.Trim().Length > 0) str.AppendLine("Họ tên: " + HoTen);
            if (GioiTinh.Trim().Length > 0) str.AppendLine("Giới tính: " + GioiTinh);
            if (SoDT.Trim().Length == 10) 
                str.AppendLine("Số ĐT: " + Regex.Replace(SoDT, @"(\d{4})(\d{3})(\d{3})", "$1-$2-$3"));
            if (Mail.Trim().Length > 0) str.AppendLine("Mail: " + Mail);
            str.AppendLine("Ngày sinh: " + NgaySinh.ToString("dd/MM/yyyy"));

            str.AppendLine();
            if (NgoaiNgu.Count > 0)
            {
                str.AppendLine("Ngoại ngữ:");
                foreach (var language in NgoaiNgu)
                    str.AppendLine(language);
            }
            else
            {
                str.AppendLine("Không có ngoại ngữ nào được chọn!!!");
            }

            str.AppendLine();
            if (dsMonHoc.ds.Count > 0)
            {
                str.AppendLine("Danh sách môn dạy:");

                foreach (var monHoc in dsMonHoc.ds)
                    str.AppendLine(monHoc.ToString());
            }
            else
            {
                str.AppendLine("Không có môn học nào được chọn!!!");
            }

            return str.ToString();
        }
    }
}
