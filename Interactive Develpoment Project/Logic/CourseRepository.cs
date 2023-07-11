using System;
namespace Interactive_Develpoment_Project.Logic
{
	public static class CourseRepository
	{

		private static List<Course> _courseList = new List<Course>();

		public static void AddCourse(Course course)
		{
			foreach(Course course1 in _courseList)
			{
				if (course1.CourseId == course.CourseId)
					throw new Exception("This course has already in course list.");
			}
			_courseList.Add(course);
		}

		public static Course GetCourseById(int id)
		{
			foreach(Course course in _courseList)
			{
				if (course.CourseId == id)
					return course;
			}
			return null;
		}

		public static List<Course> GetCourseByType(CourseType courseType)
		{
			List<Course> result = new List<Course>();
			foreach(Course course in _courseList)
			{
				if (course.CourseType == courseType)
					result.Add(course);

			}
			return result;

		}

		//read only property to read all course in list
		public static List<Course> Courses => _courseList;
	}
}

