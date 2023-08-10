using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class Teacher
	{
		private string _teacherFirstName;
		private string _teacherLastName;
		private int _teacherId;
		private string _teacherEmail;
        private int _teacherPhone;
		private DateOnly _teacherDOB;
		private double _teacherSalary;
		private string _password;

		// will implement later
		//private List<Schedule> _teacherSchedule = new List<Schedule>();


		public string FirstName
		{
			get { return _teacherFirstName; }
			set { _teacherFirstName = value; }
		}

		public string LastName
        {
            get { return _teacherLastName; }
            set { _teacherLastName = value; }
        }

        // Constructor
        public Teacher()
		{
		}
	}
}

