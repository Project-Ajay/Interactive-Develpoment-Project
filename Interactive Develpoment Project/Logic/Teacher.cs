using System;
using System.Reflection.Metadata.Ecma335;

namespace Interactive_Develpoment_Project.Logic
{
	public class Teacher
	{
		private string _teacherFirstName;
		private string _teacherLastName;
		private string _teacherId;
		private string _teacherEmail;
		private string _teacherPhone;
		private DateOnly _teacherDOB;
		private string _password;
		private static int _count = 999;

		// will implement later
		//private List<Schedule> _teacherSchedule = new List<Schedule>();


		public string TeacherFirstName
		{
			get { return _teacherFirstName; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Teacher's first name is required");
				_teacherFirstName = value;
			}
		}

        public string TeacherLastName
        {
            get { return _teacherLastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Teacher's last name is required");
                _teacherLastName = value;
            }
        }

        public string TeacherId { get { return _teacherId; } }

		public string TeacherEmail
		{
			get { return _teacherEmail; }
			set
			{
				if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
					throw new ArgumentException("Enter a valid Email");
				_teacherEmail = value;
			}
		}

		public string TeacherPhone
		{
			get { return _teacherPhone; }
			set
			{
				if (string.IsNullOrWhiteSpace(value) || !value.Any(char.IsDigit))
					throw new ArgumentException("Enter a valid phone number");
				_teacherPhone = value;
			}
		}

		public DateOnly TeacherDOB
		{
			get { return _teacherDOB; }
			set
			{
				if (value >= DateOnly.FromDateTime(DateTime.Today))
					throw new ArgumentException("Enter a valid date of birth");
				_teacherDOB = value;
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				if (value.Length < 8)
					throw new ArgumentException("Password must be atleast 8 characters long");
				_password = value;
			}
		}

		//this method generates a unique id for every new teacher registered
		private string GenerateUniqueID(string firstname, string lastname)
		{
			//count adds 1 to itself everytime the methid is called (first number would be 1000)
			_count++;
			//grabs the first character of their first and last name
			char firstChar = firstname[0];
			char secondChar = lastname[0];
			//combines everything to produce a unique string as the teachers ID
			return $"{firstChar}{secondChar}{_count}";
		}



		// Constructor
		public Teacher(string firstname, string lastname, string email, string phone, DateOnly dob, string password)
		{
			TeacherFirstName = firstname;
			TeacherLastName = lastname;
			TeacherEmail = email;
			TeacherPhone = phone;
			TeacherDOB = dob;
			Password = password;
			//calls the methid to get a unique id for every teacher and initalizes the _teacherid field with it
			_teacherId = GenerateUniqueID(firstname, lastname);
		}
	}
}

