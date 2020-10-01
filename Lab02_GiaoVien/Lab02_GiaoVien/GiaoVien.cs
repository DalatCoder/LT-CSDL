using System;
using System.Collections.Generic;
using System.Text;

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
            if (SoDT.Trim().Length > 0) str.AppendLine("Số ĐT: " + SoDT);
            if (Mail.Trim().Length > 0) str.AppendLine("Mail: " + Mail);
            str.AppendLine("Ngày sinh: " + NgaySinh.ToString("dd/MM/yyyy"));

            if (NgoaiNgu.Count > 0)
            {
                string strNgoaiNgu = "Ngoại ngữ: \n";
                foreach (var language in NgoaiNgu)
                {
                    strNgoaiNgu += language + ";\n\r";
                }
                str.Append(strNgoaiNgu);
            }

            if (dsMonHoc.ds.Count > 0)
            {
                string strMonHoc = "Danh sách môn dạy: \n";
                foreach (var monHoc in dsMonHoc.ds)
                {
                    strMonHoc += monHoc + ";\n\r";
                }
                str.AppendLine(strMonHoc);
            }

            return str.ToString();
        }
    }
}
