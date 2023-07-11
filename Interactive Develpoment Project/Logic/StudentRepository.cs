using Interactive_Develpoment_Project.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Develpoment_Project
{
    public static class StudentRepository
    {
        private static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        { 
            students.Add(student);
        }
    }
}
