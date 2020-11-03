using System.Collections.Generic;

namespace Lab05_Winform
{
	public interface IStudentDataStorage
	{
		string FilePath { get; }
		List<SinhVien> Load();
		void Write(List<SinhVien> sinhViens);
	}
}
