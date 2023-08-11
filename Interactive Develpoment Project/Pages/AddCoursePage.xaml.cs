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

    

    void OnDeleteCourse(System.Object sender, System.EventArgs e)
    {
    }

    private void OnAddCourse(object sender, EventArgs e)
    {

    }

    private void AddCourse_Clicked(object sender, EventArgs e)
    {

    }

    private void DeleteCourse_Clicked(object sender, EventArgs e)
    {

    }
}
