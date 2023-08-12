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
        private  List<Student> students = new List<Student>();

        public  void AddStudent(Student student)
        {
            foreach (Student user in students)
            {
                if (user.StudentName == student.StudentName && user.StudentPhoneNumber == student.StudentPhoneNumber
                    && user.StudentEmail == student.StudentEmail)
                    throw new Exception("Student Already Exist");
            }

            students.Add(student);
        }

        public Student FindStudentByID(int id)
        {
            Student result = null;
            foreach (Student student in students)
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
