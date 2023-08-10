using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class TeacherRepository
	{
        // List of all the teacher that will be in the database
        private List<Teacher> _teachers = new List<Teacher>();

        public List<Teacher> Teachers { get { return _teachers; } }

        // Method to add more teachers to the database
        public void CreateTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

    }
}

