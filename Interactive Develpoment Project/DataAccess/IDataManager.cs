using System;
using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.DataAccess
{
	//Interface for data input and output

	public interface IDataManager
	{
		public void WriteCourses(List<Course> courses);
		public List<Course> LoadCourses();

		public void WriteStudents(List<Student> students);
		public List<Student> LoadStudents();

		public void WriteTeachers(List<Teacher> teachers);
		public List<Teacher> LoadTeachers();
	}
}

