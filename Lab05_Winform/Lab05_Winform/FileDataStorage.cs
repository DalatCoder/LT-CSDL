using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab05_Winform
{
	public class FileDataStorage : IStudentDataStorage
	{
		public string FilePath { get; }

		public FileDataStorage(string filePath)
		{
			FilePath = filePath;
		}

		public List<SinhVien> Load()
		{
			if (!File.Exists(FilePath))
			{
				FileStream fs = File.Create(FilePath);
				fs.Close();
			}

			StreamReader reader = new StreamReader(new FileStream(FilePath, FileMode.Open));

			string line;
			List<SinhVien> sinhViens = new List<SinhVien>();

			while (true)
			{
				line = reader.ReadLine();
				if (string.IsNullOrWhiteSpace(line)) break;

				var parts = line.Split('\t');
				SinhVien sinhVien = new SinhVien();

				sinhVien.MSSV = parts[0];
				sinhVien.TenLot = parts[1];
				sinhVien.Ten = parts[2];
				sinhVien.Lop = parts[3];

				GioiTinh gioiTinh = parts[4] == "Nam" ? GioiTinh.NAM : GioiTinh.NU;
				sinhVien.gioiTinh = gioiTinh;

				sinhVien.NgaySinh = DateTime.Parse(parts[5]);
				sinhVien.SoCMND = parts[6];
				sinhVien.SDT = parts[7];
				sinhVien.DiaChi = parts[8];
				sinhVien.dsMonHocDangKy = new List<string>();

				if (parts[9] != "null")
					sinhVien.dsMonHocDangKy = new List<string>(parts[9].Split(';'));

				sinhViens.Add(sinhVien);
			}


			reader.Close();

			return sinhViens;
		}

		public void Write(List<SinhVien> sinhViens)
		{
			StreamWriter writer = new StreamWriter(new FileStream(FilePath, FileMode.Create));

			foreach (var sinhVien in sinhViens)
			{
				StringBuilder builder = new StringBuilder();

				string gioiTinh = sinhVien.gioiTinh == GioiTinh.NAM ? "Nam" : "Nữ";
				string dsMonHoc = string.Join(";", sinhVien.dsMonHocDangKy);
				if (string.IsNullOrWhiteSpace(dsMonHoc)) dsMonHoc = "null";

				builder.Append($"{sinhVien.MSSV}\t");
				builder.Append($"{sinhVien.TenLot}\t");
				builder.Append($"{sinhVien.Ten}\t");
				builder.Append($"{sinhVien.Lop}\t");
				builder.Append($"{gioiTinh}\t");
				builder.Append($"{sinhVien.NgaySinh.ToShortDateString()}\t");
				builder.Append($"{sinhVien.SoCMND}\t");
				builder.Append($"{sinhVien.SDT}\t");
				builder.Append($"{sinhVien.DiaChi}\t");
				builder.Append($"{dsMonHoc}");

				writer.WriteLine(builder.ToString());
			}

			writer.Close();
		}
	}
}
