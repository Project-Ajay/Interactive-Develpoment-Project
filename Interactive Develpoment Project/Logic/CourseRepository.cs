using System;
namespace Interactive_Develpoment_Project.Logic
{
	public  class CourseRepository
	{

		private List<Course> _courseList = new List<Course>();

		public void AddCourse(Course course)
		{
			foreach(Course course1 in _courseList)
			{
				if (course1.CourseId == course.CourseId)
					throw new Exception("This course has already in course list.");
			}
			_courseList.Add(course);
		}

		public Course GetCourseById(string id)
		{
			foreach(Course course in _courseList)
			{
                //Arnav: changed from this if (course.CourseId == id)
                if (course.CourseId.ToLower()==id.ToLower())
					return course;
			}
			return null;
		}

		public  List<Course> GetCourseByType(CourseType courseType)
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
		public  List<Course> Courses => _courseList;
	}
}

