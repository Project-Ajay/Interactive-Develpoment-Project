namespace Interactive_Develpoment_Project.Pages;
using Logic;

public partial class StudentLoginUi : ContentPage
{
    StudentRepository _studentRepository = new StudentRepository();

    public StudentRepository StudentRepository
    {
        get
        { 
            return _studentRepository;
        }
    }


    Student _selectedStudent;

    public Student SelectedStudent
    {
        get
        {
            return _selectedStudent;
        }
        set
        {
            if (_selectedStudent != value) { return; }
            _selectedStudent = value;

        }

    }


    //Initialize the list of students (HARD CODED FOR TESTING)
    private List<Student> students = new List<Student>();
    
    public StudentLoginUi()
	{
		InitializeComponent();
        students.Add(new Student("John Doe", "johndoe@gmail.com", new DateOnly(2002, 5, 15), "+1 (555) 555-5555", "Pass1234"));
        students.Add(new Student("Jane Smith", "janesmith@icloud.com", new DateOnly(2001, 10, 22), "+1 (555) 666-7777", "IcloudPwd1"));
        students.Add(new Student("Michael Johnson", "michaeljohnson@gmail.com", new DateOnly(2003, 12, 5), "+1 (555) 444-3333", "P@ssw0rd123"));

        BindingContext = this;
 
    }

    private async void StudentLoginButton_Clicked(object sender, EventArgs e)
    {


		string studentId = StudentIDEntry.Text;
		string studentPassword = StudentPasswordEntry.Text;

        Student student = _studentRepository.FindStudentByID(studentId);

        if (student != null && student.Password == studentPassword)
        {
            await DisplayAlert("Login Successful", $"Welcome {student.StudentName}", "OK");
            StudentInfoPage studentInfo = new StudentInfoPage();
            await Navigation.PushAsync(studentInfo);

        }
        else
        {
            await DisplayAlert("Error", "Invalid student ID or password. Please try again.", "OK");
            StudentIDEntry.Text = "";
            StudentPasswordEntry.Text = "";
        }


        
    }

    private async void BackToLanding_Clicked(object sender, EventArgs e)
    {

        await Navigation.PopToRootAsync();
    }
}

