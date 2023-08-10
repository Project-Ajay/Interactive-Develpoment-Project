using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class TeacherRepository
	{
        // List of all the teacher that will be in the database
        private List<Teacher> _teachers = new List<Teacher>();

        //property to access the teachers list outside of this class
        public List<Teacher> Teachers { get { return _teachers; } }

        // Method to add more teachers to the database
        public void CreateTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public Teacher FindTeacherByName(string name)
        {
            foreach(Teacher teacher in _teachers)
            {
                //compares the name provided and all the names in the database
                //learned how to ignore case while checking string here: https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
                if (string.Equals(name, teacher.TeacherName, StringComparison.OrdinalIgnoreCase))
                    return teacher;
            }
            return null;
        }

        public Teacher FindTeacherById(string id)
        {
            foreach (Teacher teacher in _teachers)
            {
                //compares the teacher's id to find a teacher in the database
                if(string.Equals(id, teacher.TeacherId, StringComparison.OrdinalIgnoreCase))
                    return teacher;
            }
            return null;
        }

    }
}

