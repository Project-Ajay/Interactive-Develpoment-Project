namespace Interactive_Develpoment_Project.Pages;
using Logic;

public partial class StudentLoginUi : ContentPage
{
    StudentRepository _studentRepository = new StudentRepository();
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
    private List<Student> students = new List<Student>
    {
        new Student("John Doe", "johndoe@gmail.com", new DateOnly(2002, 5, 15), "+1 (555) 555-5555", "Pass1234"),
        new Student("Jane Smith", "janesmith@icloud.com", new DateOnly(2001, 10, 22), "+1 (555) 666-7777", "IcloudPwd1"),
        new Student("Michael Johnson", "michaeljohnson@gmail.com", new DateOnly(2003, 12, 5), "+1 (555) 444-3333", "P@ssw0rd123")

    };
    
    public StudentLoginUi()
	{
		InitializeComponent();

    }

    private async void StudentLoginButton_Clicked(object sender, EventArgs e)
    {


		string studentId = StudentIDEntry.Text;
		string studentPassword = StudentPasswordEntry.Text;

        bool isStudentFound = false;

        foreach (Student student in students)
        {

            if (student.StudentId.ToString() == studentId && student.Password == studentPassword)
            {
                isStudentFound = true;
            }
        }
        if (isStudentFound)
        {

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

    
}