using System;
using System.Collections.Generic;

namespace Lab05_Winform
{
	public interface IStudentDataStorage
	{
		string FilePath { get; }
		List<SinhVien> Load();
		void Write(List<SinhVien> sinhViens);
	}

	public class QLSinhVien
	{
		private readonly List<SinhVien> dsSinhVien;
		private readonly IStudentDataStorage dataStorage;

		public QLSinhVien(IStudentDataStorage dataStorage)
		{
			this.dataStorage = dataStorage;
			dsSinhVien = dataStorage.Load();
		}


		public List<SinhVien> GetAll()
		{
			return dsSinhVien;
		}

		public SinhVien GetByID(string MSSV)
		{
			if (string.IsNullOrWhiteSpace(MSSV))
				throw new ArgumentException($"Tên sinh viên không hợp lệ!");

			SinhVien sv = null;

			sv = dsSinhVien.Find(s => s.MSSV == MSSV);

			return sv;
		}

		public List<SinhVien> GetByName(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException($"Tên sinh viên không hợp lệ!");

			return dsSinhVien.FindAll(sv => sv.Ten.ToLower() == name.ToLower());
		}

		public List<SinhVien> GetByClassName(string className)
		{
			if (string.IsNullOrWhiteSpace(className))
				throw new ArgumentException($"Lớp không hợp lệ!");

			return dsSinhVien.FindAll(sv => sv.Lop.ToLower() == className.ToLower());
		}

		public void UpdateByID(string MSSV, SinhVien sinhVienMoi)
		{
			if (string.IsNullOrWhiteSpace(MSSV))
				throw new ArgumentException($"Mã số sinh viên không hợp lệ!");

			var isExist = dsSinhVien.Exists(sv => sv.MSSV == MSSV);
			if (!isExist)
				throw new ArgumentException($"Sinh viên có mã số {MSSV} không tồn tại!");			

			var index = dsSinhVien.FindIndex(sv => sv.MSSV == MSSV);
			dsSinhVien[index] = sinhVienMoi;

			dataStorage.Write(dsSinhVien);
		}

		public void DeleteByID(string MSSV)
		{
			if (string.IsNullOrWhiteSpace(MSSV))
				throw new ArgumentException($"Mã số sinh viên không hợp lệ!");

			var sinhVien = dsSinhVien.Find(sv => sv.MSSV == MSSV);
			if (sinhVien is null)
				throw new ArgumentException($"Không tồn tại sinh viên có mã số {MSSV}");

			dsSinhVien.Remove(sinhVien);
			dataStorage.Write(dsSinhVien);
		}

		public void Add(SinhVien sinhVien)
		{
			if (sinhVien is null)
				throw new ArgumentException($"Sinh viên không hợp lệ!");

			var isExist = dsSinhVien.Exists(sv => sv.MSSV == sinhVien.MSSV);
			if (isExist)
				throw new ArgumentException($"Sinh viên có mã số {sinhVien.MSSV} đã tồn tại!");

			dsSinhVien.Add(sinhVien);
			dataStorage.Write(dsSinhVien);
		}
	}
}
