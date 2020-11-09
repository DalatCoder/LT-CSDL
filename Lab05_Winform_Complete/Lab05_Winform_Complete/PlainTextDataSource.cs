using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab05_Winform_Complete
{
	public class PlainTextDataSource : IDataSource
	{
		public string FilePath { get; private set; }

		public PlainTextDataSource(string filePath)
		{
			FilePath = filePath;
		}

		public List<Student> GetStudents()
		{
			string line;
			var studentList = new List<Student>();

			if (File.Exists(FilePath))
			{
				using (var reader = new StreamReader(new FileStream(FilePath, FileMode.Open)))
				{
					while ((line = reader.ReadLine()) != null)
					{
						var sv = ParseLine(line);
						studentList.Add(sv);
					}
				}
			}

			return studentList;
		}

		public void Save(List<Student> students)
		{
			if (students.Count == 0) return;

			using (var writer = new StreamWriter(new FileStream(FilePath, FileMode.Create, FileAccess.Write)))
			{
				foreach (var student in students)
				{
					writer.WriteLine(FormatStudent(student));
				}
			}
		}

		private enum ColumnIndex
		{
			Id,
			FirstName,
			LastName,
			Gender,
			DateOfBirth,
			ClassName,
			IdentityNumber,
			PhoneNumber,
			Address,
			Subject
		}

		private Student ParseLine(string line)
		{
			var parts = line.Split('|');
			var subjects = parts[(int)ColumnIndex.Subject].Split('^').ToList();

			return new Student
			{
				ID = parts[(int)ColumnIndex.Id],
				FirstName = parts[(int)ColumnIndex.FirstName],
				LastName = parts[(int)ColumnIndex.LastName],
				Gender = parts[(int)ColumnIndex.Gender] == "Nam" ? Gender.MALE : Gender.FEMALE,
				DateOfBirth = DateTime.Parse(parts[(int)ColumnIndex.DateOfBirth]),
				ClassName = parts[(int)ColumnIndex.ClassName],
				IdentityNumber = parts[(int)ColumnIndex.IdentityNumber],
				PhoneNumber = parts[(int)ColumnIndex.PhoneNumber],
				Address = parts[(int)ColumnIndex.Address],
				SubjectList = subjects
			};
		}

		private string FormatStudent(Student student)
		{
			return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}",
				student.ID,
				student.FirstName,
				student.LastName,
				student.Gender == Gender.MALE ? "Nam" : "Nữ",
				student.DateOfBirth,
				student.ClassName,
				student.IdentityNumber,
				student.PhoneNumber,
				student.Address,
				string.Join("^", student.SubjectList));
		}
	}
}
