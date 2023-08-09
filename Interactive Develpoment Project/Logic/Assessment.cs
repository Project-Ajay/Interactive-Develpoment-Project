using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class Assessment
	{
		private string _title;

		public string Title
		{
			get { return _title; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("The title can not be null or empty.");
				_title = value;
			}
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set
			{
				_description = value;
			}
		}

		private DateOnly _dateCreated;

		public DateOnly DateCreated
		{
			get { return _dateCreated; }
			set
			{
				_dateCreated = value;
			}
		}

		private double _grade;

		public double Grade
		{
			get { return _grade; }
			set
			{
				if (value <= 0)
					throw new Exception(" The grade can not be negative.");
				_grade = value;
			}
		}

		private TimeSpan _startTime;

		public TimeSpan StartTime
		{
			get { return _startTime; }
			set
			{
				_startTime = value;
			}
		}

		private TimeSpan _endTime;

		public TimeSpan EndTime
		{
			get { return _endTime; }
			set
			{
				if (_endTime < _startTime)
					throw new Exception("End Time must be after the start time.");
				_endTime = value;
			}
		}

		public Assessment(string title,string decription,DateOnly dateCreated, double grade,TimeSpan startTime,TimeSpan endTime)
		{
			Title = title;
			Description = decription;
			DateCreated = dateCreated;
			Grade = grade;
			StartTime = startTime;
			EndTime = endTime;
		}

        public Assessment(string title, string decription, DateOnly dateCreated, double grade)
        {
            Title = title;
            Description = decription;
            DateCreated = dateCreated;
            Grade = grade;
           
        }
    }
}

