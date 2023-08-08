using System;
using Interactive_Develpoment_Project.Logic;
using System.Text.Json;

namespace Interactive_Develpoment_Project.DataAccess
{
	public class DataJsonManager : IDataManager
	{
		string _fileName;

		public DataJsonManager(string fileName)
		{
			_fileName = fileName;
		}

		public void WriteStudents(List<Student> students)
		{
			using (FileStream writer = new FileStream(_fileName, FileMode.OpenOrCreate))
			{
				JsonSerializer.Serialize(writer, students);

			}
		}

		public List<Student> LoadStudents()
		{
			List<Student> students;
			using (FileStream reader = new FileStream(_fileName, FileMode.Open))
			{
				students = JsonSerializer.Deserialize<List<Student>>(reader);
			}
			return students;
		}

		public void WriteCourses(List<Course> courses)
		{
			using (FileStream writer = new FileStream(_fileName, FileMode.OpenOrCreate))
			{
				JsonSerializer.Serialize(writer, _fileName);
			}
		}

		public List<Course> LoadCourses()
		{
			List<Course> courses;
			using (FileStream reader = new FileStream(_fileName, FileMode.Open))
			{
				courses = JsonSerializer.Deserialize<List<Course>>(reader);
			}
			return courses;
		}

		public void WriteTeachers(List<Teacher> teachers)
		{
			using (FileStream writer = new FileStream(_fileName, FileMode.OpenOrCreate))
			{
				JsonSerializer.Serialize(writer, _fileName);
			}
		}

		public List<Teacher> LoadTeachers()
		{
			List<Teacher> teachers;
			using (FileStream reader = new FileStream(_fileName, FileMode.Open))
			{
				teachers = JsonSerializer.Deserialize<List<Teacher>>(reader);
			}
			return teachers;
		}
	}
}

