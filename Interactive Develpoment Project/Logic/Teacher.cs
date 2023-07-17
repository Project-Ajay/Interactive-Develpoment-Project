using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class Teacher
	{
		private string _teacherFirstName;
		private string _teacherLastName;
		private int _teacherId;
		private string _teacherEmail;
		private DateOnly _teacherDOB;
        private int? _teacherPhone;

		private string _teacherAddress;
		private string _teacherCity;
		private string _teacherZip;
		private string _teacherCountry;

        private string _teacherDepartment;
		private double _teacherSalary;
		private bool _teacherEmploymentStatus;

        private List<string> _teacherSubjects = new List<string>();
		private List<Schedule> _teacherSchedule = new List<Schedule>();


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

