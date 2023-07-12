using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Develpoment_Project.Logic
{
    public static class StudentRepository
    {
        private static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            //foreach (Student user in students)
            //{
            //    if()
            //}

            students.Add(student);
        }

        public static Student FindStudentByID(int id)
        {
            Student result = null;
            foreach (Student student in students)
            {
                if(student.StudentId == id)
                    result = student;
            }
            return result;
        }
    }
}
