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

    }
}

