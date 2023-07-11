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
				if (string.IsNullOrEmpty(value))
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

    }
}

