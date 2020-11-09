using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Winform_Complete
{
	public delegate bool CompareFunc(Student student, SearchType searchType, string keyword);

	public class StudentManager
	{
		private IDataSource _dataSource;
		private List<Student> _students;

		public StudentManager(IDataSource dataSource)
		{
			_dataSource = dataSource;
			_students = _dataSource.GetStudents();
		}

		public List<Student> GetStudents()
		{
			return _students;
		}

		public void Add(Student student)
		{
			_students.Add(student);
			_dataSource.Save(_students);
		}

		public void AddOrUpdate(Student student)
		{
			var index = FindIndex(student);

			if (index < 0) Add(student);
			else _students[index] = student;

			_dataSource.Save(_students);
		}

		public int FindIndex(Student student)
		{
			return _students.FindIndex(s => s.ID == student.ID);
		}

		public Student FindById(string id)
		{
			return _students.Find(s => s.ID == id);
		}

		public List<Student> FindStudents(CompareFunc compareFunc, SearchType searchType, string keyword)
		{
			var students = new List<Student>();

			foreach (var student in _students)
			{
				if (compareFunc(student, searchType, keyword))
					students.Add(student);
			}

			return students;
		}
	}

	public class Student
	{
		public string ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Gender Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string ClassName { get; set; }
		public string IdentityNumber { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public List<string> SubjectList { get; set; }

		public Student()
		{
			SubjectList = new List<string>();
		}

		public Student(string iD, string firstName, string lastName, Gender gender, DateTime dateOfBirth, string className, string identityNumber, string phoneNumber, string address, List<string> subjectList)
		{
			ID = iD;
			FirstName = firstName;
			LastName = lastName;
			Gender = gender;
			DateOfBirth = dateOfBirth;
			ClassName = className;
			IdentityNumber = identityNumber;
			PhoneNumber = phoneNumber;
			Address = address;
			SubjectList = subjectList;
		}
	}
}
