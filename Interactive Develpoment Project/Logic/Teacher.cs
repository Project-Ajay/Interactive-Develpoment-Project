using System;
using System.Reflection.Metadata.Ecma335;

namespace Interactive_Develpoment_Project.Logic
{
	public class Teacher
	{
		private string _teacherName;
		private string _teacherId;
		private string _teacherEmail;
		private string _teacherPhone;
		private DateOnly _teacherDOB;
		private float _teacherSalary;
		private string _password;
		private static int _count = 999;

		// will implement later
		//private List<Schedule> _teacherSchedule = new List<Schedule>();


		public string TeacherName
		{
			get { return _teacherName; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Teacher's name is required");
				_teacherName = value;
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
				if (string.IsNullOrWhiteSpace(value) || value.Any(char.IsLetter) || value.Any(char.IsSymbol))
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

		public float TeacherSalary
		{
			get { return _teacherSalary; }
			set
			{
				if (value <= 0)
					throw new ArgumentException("Salary must be greater than 0");
				_teacherSalary = value;
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

		private void GenerateUniqueID()
		{
			_count++;

			_teacherId = $"CA{_count}";
		}



		// Constructor
		public Teacher(string name, string email, string phone, DateOnly dob, float salary, string password)
		{
			TeacherName = name;
			TeacherEmail = email;
			TeacherPhone = phone;
			TeacherDOB = dob;
			TeacherSalary = salary;
			Password = password;
			GenerateUniqueID();
		}
	}
}

