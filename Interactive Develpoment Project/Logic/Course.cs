﻿using System;
namespace Interactive_Develpoment_Project.Logic
{
	public class Course
	{
		private string _courseId;

		public string CourseId
		{
			get { return _courseId; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("The course Id was not set properly.");
				_courseId = value;
			}
		}

		private CourseType _courseType;
		public CourseType CourseType
		{
			get { return _courseType; }
			init
			{
				_courseType = value;
			}
		}

		public string Image
		{

			get { return $"{CourseType}.png"; }

		}
		

		private string _courseName;
		public string CourseName
		{
			get { return _courseName; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Course Name was not set properly.");
				_courseName = value;
						
			}
		}

		private string _description;
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		List<Assessment> _assessments = new List<Assessment>();

		public List<Assessment> Assessments
		{
			get { return _assessments; }
		}

		public void AddAssessment(Assessment assessment)
		{
			foreach(Assessment assessment1 in _assessments)
			{
				if (assessment1.Title.ToLower() == assessment.Title.ToLower())
					throw new Exception("The same assessment has already added into list.");
			}
			_assessments.Add(assessment);

		}

		public double FinalGrades
		{
			get
			{
				double result = 0;
				foreach(Assessment assessment in _assessments)
				{
					result += assessment.Grade;
				}
				return result;
			}
		}

		public Course(string courseId,CourseType courseType,string courseName,string description)
		{
			CourseId = courseId;
			CourseType = courseType;
			CourseName = courseName;
			Description = description;
		}

        public override string ToString()
        {
			return $"{CourseId},{CourseType},{CourseName},{Description}";
        }
    }
}

