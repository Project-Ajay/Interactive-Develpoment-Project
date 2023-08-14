using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class Assignment:Assessment
	{


		private DateOnly _dueDate;

		public DateOnly DueDate
		{
			get { return _dueDate; }
			set
			{
				if (_dueDate < base.DateCreated)
				{
					throw new ArgumentException("Due date has to be set after creation date");
				}
				_dueDate = value;
			}
		}

		

		public Assignment(string title, string decription, DateOnly dateCreated,double percentageOfCourse ,DateOnly dueDate)
			:base(title,decription,dateCreated,percentageOfCourse)
		{
			DueDate = dueDate;
		}
	}
}

