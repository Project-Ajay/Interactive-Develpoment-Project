﻿using System;
namespace Interactive_Develpoment_Project.Logic
{
	public static class TeacherRepository
	{
        // List of all the teacher that will be in the database
        private static List<Teacher> _teachers = new List<Teacher>();

        // Method to add more teachers to the database
        public static void CreateTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

    }
}

