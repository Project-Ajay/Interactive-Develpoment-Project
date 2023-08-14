using Interactive_Develpoment_Project.Logic;
using Interactive_Develpoment_Project.DataAccess;

namespace Interactive_Develpoment_Project.Pages;

public partial class AddCoursePage : ContentPage
{

	private CourseRepository _courseRepository = new CourseRepository();

    public CourseRepository CourseRepository => _courseRepository;

    private Course _selectedCourse;

    public Course SelectedCourse
    {
        get { return _selectedCourse; }
        set
        {
            if (_selectedCourse == value) return;
            _selectedCourse = value;
            OnPropertyChanged();
        }
    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    CourseListView.ItemsSource = null;
    //    CourseListView.ItemsSource = CourseRepository.Courses;
    //}

    string _fileName = "project.json";

    IDataManager _dataManager;

    public AddCoursePage()
	{
		InitializeComponent();
		CourseTypePicker.ItemsSource = Enum.GetValues(typeof(CourseType));
        //_courseRepository.AddCourse(new Course("ger", CourseType.elective, "fegr", "gegerg"));
        //_courseRepository.AddCourse(new Course("fwfe", CourseType.elective, "grg", "grgr"));

        string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, _fileName);
        _dataManager = new DataJsonManager(filePath);

        this.BindingContext = this;
	}

    private void AddCourse_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            //Arnav: Fixed errors here make sure everything is correct
            string courseId = CourseIdEntry.Text;
            CourseType courseType = (CourseType)CourseTypePicker.SelectedItem;
            string courseName = CourseNameEntry.Text;
            string description = CourseDescriptionEntry.Text;

            Course course = new Course(courseId, courseType, courseName, description);

            DisplayAlert("New Course was Created", $"Course Id: {course.CourseId}\nCourse Name:{course.CourseName}\nDescription:{course.Description}", "Ok");

            _courseRepository.AddCourse(course);
            CourseListView.ItemsSource = null;
            CourseListView.ItemsSource = _courseRepository.Courses;
            _courseRepository.SaveCourses(_dataManager);
        }
        catch (Exception ex)
        {
            DisplayAlert("Invalid Input", $"{ex.Message}", "Ok");
        }

    }

    private void DeleteCourse_Clicked(System.Object sender, System.EventArgs e)
    {

        _courseRepository.Courses.Remove(SelectedCourse);
        DisplayAlert("Information", $"The course with {SelectedCourse.CourseName} has been removed.", "Ok");
        CourseListView.ItemsSource = null;
        CourseListView.ItemsSource = CourseRepository.Courses;
    }

    void BackToAdmin(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }
}
