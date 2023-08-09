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
				_dueDate = value;
			}
		}

		public Assignment(string title, string decription, DateOnly dateCreated, double grade,DateOnly dueDate)
			:base(title,decription,dateCreated,grade)
		{
			DueDate = dueDate;
		}
	}
}

