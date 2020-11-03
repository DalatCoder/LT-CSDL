using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab05_Winform
{
	public class JSONDataStorage : IStudentDataStorage
	{
		public string FilePath { get; set; }

		public JSONDataStorage(string filePath)
		{
			FilePath = filePath;
		}

		public List<SinhVien> Load()
		{
			using (StreamReader r = new StreamReader(FilePath))
			{
				string json = r.ReadToEnd();
				List<SinhVien> items = JsonConvert.DeserializeObject<List<SinhVien>>(json);
				return items;
			}
		}

		public void Write(List<SinhVien> sinhViens)
		{
			using (StreamWriter file = File.CreateText(FilePath))
			{
				JsonSerializer serializer = new JsonSerializer();
				//serialize object directly into file stream
				serializer.Serialize(file, sinhViens);
			}
		}
	}
}
