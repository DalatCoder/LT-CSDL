using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Lab05_Winform
{
	public class JSONDataStorage : IStudentDataStorage
	{
		public string FilePath { get; }

		public JSONDataStorage(string filePath)
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
