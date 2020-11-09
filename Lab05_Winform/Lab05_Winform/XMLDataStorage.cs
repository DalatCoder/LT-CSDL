using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lab05_Winform
{
	public class XMLDataStorage : IStudentDataStorage
	{
		public string FilePath { get; }

		public XMLDataStorage(string filePath)
		{
			FilePath = filePath;
		}

		public List<SinhVien> Load()
		{
			throw new NotImplementedException();
		}

		public void Write(List<SinhVien> sinhViens)
		{
			XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");

		}
	}
}
