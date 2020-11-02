using System;
using System.Collections.Generic;

namespace Lab05_Winform
{
	public enum GioiTinh
	{
		NAM,
		NU
	}

	public class SinhVien
	{
		public string MSSV { get; set; }
		public string TenLot { get; set; }
		public string SoCMND { get; set; }
		public GioiTinh gioiTinh { get; set; }
		public DateTime NgaySinh{ get; set; }
		public string DiaChi { get; set; }
		public string Ten { get; set; }
		public string Lop { get; set; }
		public string SDT { get; set; }
		public List<string> dsMonHocDangKy { get; set; }

		public SinhVien()
		{
			dsMonHocDangKy = new List<string>();
		}

		public SinhVien(string mSSV, string tenLot, string soCMND, GioiTinh gioiTinh, DateTime ngaySinh, string diaChi, string ten, string lop, string sDT, List<string> dsMonHocDangKy)
		{
			MSSV = mSSV;
			TenLot = tenLot;
			SoCMND = soCMND;
			this.gioiTinh = gioiTinh;
			NgaySinh = ngaySinh;
			DiaChi = diaChi;
			Ten = ten;
			Lop = lop;
			SDT = sDT;
			this.dsMonHocDangKy = dsMonHocDangKy;
		}
	}
}
