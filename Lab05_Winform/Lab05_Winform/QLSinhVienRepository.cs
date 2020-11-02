using System;
using System.Collections.Generic;

namespace Lab05_Winform
{
	public class QLSinhVienRepository
	{
		private List<SinhVien> dsSinhVien;

		public QLSinhVienRepository()
		{
			dsSinhVien = new List<SinhVien>()
			{
				new SinhVien
				{
					MSSV = "1812756",
					TenLot = "Nguyen Trong",
					Ten = "Hieu",
					NgaySinh = DateTime.Now,
					Lop = "CTK42",
					SoCMND = "251165227",
					SDT = "0374408253",
					DiaChi = "Da Lat",
					gioiTinh = GioiTinh.NAM,
					dsMonHocDangKy = new List<string>() { "Hệ điều hành" }
				},
				new SinhVien
				{
					MSSV = "1812751",
					TenLot = "Nguyen Thi",
					Ten = "Ha",
					NgaySinh = DateTime.Now,
					Lop = "CTK42",
					SoCMND = "251165228",
					SDT = "0274408254",
					DiaChi = "Da Lat",
					gioiTinh = GioiTinh.NU,
					dsMonHocDangKy = new List<string>() { "Mạng máy tính" }
				},
				new SinhVien
				{
					MSSV = "1712750",
					TenLot = "Phan Quoc",
					Ten = "Trung",
					NgaySinh = DateTime.Now,
					Lop = "CTK41",
					SoCMND = "251165229",
					SDT = "0274408256",
					DiaChi = "Da Lat",
					gioiTinh = GioiTinh.NAM,
					dsMonHocDangKy = new List<string>() { "Mạng máy tính" }
				}
			};
		}

		public List<SinhVien> GetAll()
		{
			return dsSinhVien;
		}

		public SinhVien GetByID(string MSSV)
		{
			SinhVien sv = null;

			sv = dsSinhVien.Find(s => s.MSSV == MSSV);

			return sv;
		}

		public List<SinhVien> GetByName(string name)
		{
			return dsSinhVien.FindAll(sv => sv.Ten.ToLower() == name.ToLower());
		}

		public List<SinhVien> GetByClassName(string className)
		{
			return dsSinhVien.FindAll(sv => sv.Lop.ToLower() == className.ToLower());
		}

		public void UpdateByID(string MSSV, SinhVien sinhVienMoi)
		{
			var isExist = dsSinhVien.Exists(sv => sv.MSSV == MSSV);
			if (!isExist)
				throw new ArgumentException($"Sinh viên có mã số {MSSV} không tồn tại!");

			if (MSSV is null)
				throw new ArgumentException($"Mã số sinh viên không hợp lệ!");

			var index = dsSinhVien.FindIndex(sv => sv.MSSV == MSSV);
			dsSinhVien[index] = sinhVienMoi;
		}

		public void DeleteByID(string MSSV)
		{
			var isExist = dsSinhVien.Exists(sv => sv.MSSV == MSSV);
			if (!isExist)
				throw new ArgumentException($"Sinh viên có mã số {MSSV} không tồn tại!");

			var index = dsSinhVien.FindIndex(sv => sv.MSSV == MSSV);
			dsSinhVien.RemoveAt(index);
		}

		public void Save(SinhVien sinhVien)
		{
			var isExist = dsSinhVien.Exists(sv => sv.MSSV == sinhVien.MSSV);
			if (isExist)
				throw new ArgumentException($"Sinh viên có mã số {sinhVien.MSSV} đã tồn tại!");

			dsSinhVien.Add(sinhVien);
		}
	}
}
