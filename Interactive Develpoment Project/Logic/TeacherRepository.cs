﻿using System;
using Interactive_Develpoment_Project.DataAccess;
namespace Interactive_Develpoment_Project.Logic
{
	public class TeacherRepository
	{
        // making a static teacher repository to use it globally
        private static TeacherRepository _teacherRepository = new TeacherRepository();

        //public read-only property to access the teacher repository
        public static TeacherRepository Repository
        {
            get
            {
                return _teacherRepository;
            }
        }

        // List of all the teacher that will be in the database
        private List<Teacher> _teachers = new List<Teacher>();

        //property to access the teachers list outside of this class
        public List<Teacher> Teachers { get { return _teachers; } }

        // Method to add more teachers to the database
        public void CreateTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        //Method to delete teachers from the database
        public void DeleteTeacher(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }

        public Teacher FindTeacherByFirstName(string firstname)
        {
            foreach(Teacher teacher in _teachers)
            {
                //compares the firstname provided and all the firstnames in the database
                //learned how to ignore case while checking string here: https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
                if (string.Equals(firstname, teacher.TeacherFirstName, StringComparison.OrdinalIgnoreCase))
                    return teacher;
            }
            return null;
        }

        public Teacher FindTeacherByLastName(string lastname)
        {
            foreach (Teacher teacher in _teachers)
            {
                //compares the lastname provided and all the lastnames in the database
                //learned how to ignore case while checking string here: https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
                if (string.Equals(lastname, teacher.TeacherLastName, StringComparison.OrdinalIgnoreCase))
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

        public void SaveTeachers(IDataManager dataManager)
        {
            dataManager.WriteTeachers(_teachers);
        }

        public void ReadTeachers(IDataManager dataManager)
        {
            try
            {
                _teachers = dataManager.LoadTeachers();
            }
            catch(FileNotFoundException ex)
            {
                _teachers = new List<Teacher>();
            }
        }


    }
}

