using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class AddCoursePage : ContentPage
{

	private List<Course> _courses = new List<Course>();

	public AddCoursePage()
	{
		InitializeComponent();
		CourseTypePicker.ItemsSource = Enum.GetValues(typeof(CourseType));
	}

    

    private void OnDeleteCourse(System.Object sender, System.EventArgs e)
    {
		try
		{
			string courseId = CourseIdEntry.Text;
			CourseType courseType =(CourseType) CourseTypePicker.SelectedItem;
			string courseName = CourseNameEntry.Text;
			string description = DescriptionEntry.Text;

			Course course = new Course(courseId, courseType, courseName, description);

			DisplayAlert("New Course was Created", $"Course Id: {course.CourseId}\nCourse Name:{course.CourseName}\nDescription:{course.Description}", "Ok");

			_courses.Add(course);
		}
		catch(Exception ex)
		{
			DisplayAlert("Invalid Input", $"{ex.Message}", "Ok");
		}
    }
}
