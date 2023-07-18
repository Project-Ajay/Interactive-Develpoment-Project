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

		private DateOnly _date;

		public DateOnly Date
		{
			get { return _date; }
			set
			{
				_date = value;
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

		public Assessment(string title,string decription,DateOnly date, double grade)
		{
			Title = title;
			Description = decription;
			Date = date;
			Grade = grade;
		}
	}
}

