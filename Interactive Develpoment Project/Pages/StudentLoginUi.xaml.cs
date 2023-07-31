namespace Interactive_Develpoment_Project.Pages;
using Logic;

public partial class StudentLoginUi : ContentPage
{
    //Initialize the list of students (HARD CODED FOR TESTING)
    private List<Student> students = new List<Student>
    {
        new Student("John Doe", "johndoe@gmail.com", 1000, new DateOnly(2002, 5, 15), "+1 (555) 555-5555", "Pass1234", true),
        new Student("Jane Smith", "janesmith@icloud.com", 1001, new DateOnly(2001, 10, 22), "+1 (555) 666-7777", "IcloudPwd1", true),
        new Student("Michael Johnson", "michaeljohnson@gmail.com", 1002, new DateOnly(2003, 12, 5), "+1 (555) 444-3333", "P@ssw0rd123", true)
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

            if (student.StudentId.ToString() == studentId && student.Password.ToString() == studentPassword)
            {
                isStudentFound = true;
            }
        }
        if (isStudentFound)
        {

            StudentInfoUi studentInfoUi = new StudentInfoUi();
            await Navigation.PushAsync(studentInfoUi);
        }
        else
        {
            await DisplayAlert("Error", "Invalid student ID or password. Please try again.", "OK");
        }
    }
}