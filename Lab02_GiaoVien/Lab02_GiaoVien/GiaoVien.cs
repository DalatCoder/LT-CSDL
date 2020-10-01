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

            str.AppendLine("Mã số: " + MaSo);
            str.AppendLine("Họ tên: " + HoTen);
            str.AppendLine("Giới tính: " + GioiTinh);
            str.AppendLine("Số ĐT: " + SoDT);
            str.AppendLine("Mail: " + Mail);

            if (NgoaiNgu.Count > 0)
            {
                string strNgoaiNgu = "Ngoại ngữ: ";
                foreach (var language in NgoaiNgu)
                {
                    strNgoaiNgu += language + "; ";
                }
                str.AppendLine(strNgoaiNgu);
            }

            if (dsMonHoc.ds.Count > 0)
            {
                string strMonHoc = "Danh sách môn dạy: ";
                foreach (var monHoc in dsMonHoc.ds)
                {
                    strMonHoc += monHoc + "; ";
                }
                str.AppendLine(strMonHoc);
            }

            return str.ToString();
        }
    }
}
