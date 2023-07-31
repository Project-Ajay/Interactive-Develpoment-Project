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
		private bool _isDomesticStudent = true;
		private string _password;

		private int _count = 0999;


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
					throw new Exception("Invalid password. It must be at least 8 characters long and contain at least one uppercase letter and one digit.");
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


        //Constructor 
        public Student(string StudentName,string StudentEmail,int StudentId,DateOnly DateOfBirth,string StudentPhoneNumber,string password,bool studentType)
		{
			_count++;
			_studentId = _count;

			_studentName = StudentName;
			_studentId = StudentId;
			_studentEmail = StudentEmail;
			_dateOfBirth = DateOfBirth;
			_studentPhoneNumber = StudentPhoneNumber;
			_password = password;
			_isDomesticStudent = studentType;


		}
    }
}

