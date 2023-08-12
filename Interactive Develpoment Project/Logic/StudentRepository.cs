using Interactive_Develpoment_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Develpoment_Project.Logic
{
    public  class StudentRepository
    {
        private  List<Student> _students = new List<Student>();

        public List<Student> Students => _students;

        public void AddStudent(Student student)
        {
            foreach(Student student1 in _students)
            {
                if (student1.StudentName.ToLower() == student.StudentName.ToLower())
                    throw new Exception("This student has already in the student list.");
                
            }
            _students.Add(student);
        }

        public Student FindStudentByID(int id)
        {
            Student result = null;
            foreach (Student student in _students)
            {
                if(student.StudentId == id)
                    result = student;
            }
            return result;
        }

        //Arnav: added "temp" to remove the error
        public void ReadData(IDataManager temp)
        { }
    }
}
