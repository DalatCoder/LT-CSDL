using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Page60_Buoi3
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public string PhongBan { get; set; }
        public string Email { get; set; }
        public string Hinh { get; set; }

        public NhanVien()
        {

        }
        public NhanVien
            (
                string maNV, string tenNV, DateTime ngaySinh, 
                string gioiTinh, string soDT, string diaChi, 
                string phongBan, string email, string hinh)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.SoDT = soDT;
            this.DiaChi = diaChi;
            this.PhongBan = phongBan;
            this.Email = email;
            this.Hinh = hinh;
        }
    }
}
