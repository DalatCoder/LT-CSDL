using System.Collections.Generic;

namespace Lab05_Winform_Complete
{
	public interface IDataSource
	{
		List<Student> GetStudents();
		void Save(List<Student> students);
	}
}
