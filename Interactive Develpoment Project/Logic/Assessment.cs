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

		private double _pecentageOfCourse;

		public double PercentageOfCourse
		{
			get { return _pecentageOfCourse; }
			set
			{
				if (value <= 0)
					throw new Exception("The weight of assessment should be more than 0.");
				_pecentageOfCourse = value;
			}
		}

		private double _marks;

		public void SetMarks(double marks)
		{
			if (marks < 0 & marks > 100)
				throw new Exception("The marks for each assessment can not be negative or more than 100.");
			_marks = marks;
		}

		public double Grade
		{
			get { return _marks * _pecentageOfCourse; }
		}

		public Assessment(string title,string decription,DateOnly dateCreated,TimeSpan startTime,TimeSpan endTime,double _percentageOfCourse)
		{
			Title = title;
			Description = decription;
			DateCreated = dateCreated;
			
			StartTime = startTime;
			EndTime = endTime;
			PercentageOfCourse = PercentageOfCourse;
		}

        public Assessment(string title, string decription, DateOnly dateCreated,double percentageOfCourse)
        {
            Title = title;
            Description = decription;
            DateCreated = dateCreated;
			PercentageOfCourse = percentageOfCourse;
            
           
        }
    }
}

