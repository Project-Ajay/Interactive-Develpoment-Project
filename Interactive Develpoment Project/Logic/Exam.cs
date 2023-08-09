using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class Exam:Assessment
	{
		private bool _isOpenBook;

		public bool IsOpenBook
		{
			get { return _isOpenBook; }
			set
			{
				_isOpenBook = value;
			}
		}

		public TimeSpan Duration
		{
			get
			{
				return base.EndTime-base.StartTime;
			}
		}

		public Exam(string title, string decription, DateOnly dateCreated, TimeSpan startTime, TimeSpan endTime,double percentageOfCourse,bool isOpenBook)
			:base(title,decription,dateCreated,startTime,endTime,percentageOfCourse)
		{
			_isOpenBook = isOpenBook;
		}
	}
}

