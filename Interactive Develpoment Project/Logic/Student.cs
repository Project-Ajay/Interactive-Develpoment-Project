using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class Student
	{
		private string _studentName;
		private string _studentEmail;
		private int _studentId;
        private DateOnly _dateOfBirth;
		private string _studentPhoneNumber;
		private string _password;

		private List<Course> _selectedCourses = new List<Course>();

		private static int _count = 0999;


		//StudentName property
		public string StudentName
		{
			get
			{
				return _studentName;
			}
			set 
			{
				// if the value is empty an error will be thrown
				if (string.IsNullOrEmpty(value) || value.Any(char.IsDigit))
					throw new Exception("INPUT CAN'T BE EMPTY");
				_studentName = value;
			}
		}

		//StudentEmail Property 
		public string StudentEmail
		{
			get 
			{
				return _studentEmail;
			}
			set 
			{
				// if value doesn'y contain "@" or "." an error thrown
				if (!value.Contains("@") || (!value.Contains(".")))
					throw new Exception("Invalid Email");
				_studentEmail = value;
			}
		}

		//StudentPhoneNumber Property

		public string StudentPhoneNumber
		{
			get
			{
				return _studentPhoneNumber;
			}
			set
			{
				// string is empty or if it contains the string contins a letter an expection will be thrown 
                if (string.IsNullOrEmpty(value) || value.Any(char.IsLetter))
					throw new Exception("Invalid Input");
				_studentPhoneNumber = value;
			}
		}

		//Student Date of Birth Property

		public DateOnly DateOfBirth 
		{
			get
			{
				return _dateOfBirth;
			}
			set
			{
                if (value >= DateOnly.FromDateTime(DateTime.Today))
                    throw new Exception("Invalid Input.");
                _dateOfBirth = value;
            }
		}

		// Student ID Property

		public int StudentId
		{
			get
			{
				return _studentId;
			}
		}

        //Student Password

        public string Password
		{
			get
			{
				return _password;			
			}
			set 
			{
				if (value.Length < 8 || !ContainsUppercase(value) || !ContainsNumber(value))
				{
					throw new Exception("Invalid password.\n It must be at least 8 characters long and contain at least one uppercase letter and one digit.");
				}
				_password = value;
			}
		}


		//Passwaord Validation

		private bool ContainsUppercase(string password)
		{
			return password.Any(char.IsUpper);
		}

        private bool ContainsNumber(string password)
        {
            return password.Any(char.IsDigit);
        }

		public void AddCourse(Course course)
		{
			foreach(Course course1 in _selectedCourses)
			{
				if (course1.CourseId.ToLower() == course1.CourseId.ToLower())
					throw new Exception("This course has already selected.");
				_selectedCourses.Add(course);
			}
		}

		public List<Course> SelectedCourses => _selectedCourses;



        //Constructor
		//studentId auto generated
        public Student(string studentName,string studentEmail,DateOnly dateOfBirth,string studentPhoneNumber,string password)
		{
			StudentName = studentName;
			StudentEmail = studentEmail;
			StudentPhoneNumber = studentPhoneNumber;
			Password = password;
			DateOfBirth = dateOfBirth;
			_studentId = _count++;

	

			 
		}
        public override string ToString()
        {
			return $"{StudentId},{StudentName}";
        }
    }
}

