using Interactive_Develpoment_Project.Logic;
using Interactive_Develpoment_Project.DataAccess;
namespace Interactive_Develpoment_Project.Pages;

public partial class AddStudentPage : ContentPage
{
	private StudentRepository _studentRepository = new StudentRepository();

	string _fileName="project.json";

	IDataManager _dataManager;

	public AddStudentPage()
	{
		InitializeComponent();
		string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, _fileName);
		_dataManager = new DataJsonManager(filePath);

		
	}

    private void AddStudent_Clicked(object sender, EventArgs e)
    {
		try
		{
			string studentName = StudentNameEnty.Text;
			string studentEmail = EmailEntry.Text;
			string studentPhoneNumber = PhoneNumberEntry.Text;
			string studentPassword = PasswordEntry.Text;
			DateOnly BirthDate = DateOnly.FromDateTime(BirthDatePicker.Date);

			Student student = new Student(studentName, studentEmail, BirthDate, studentPhoneNumber, studentPassword);

			DisplayAlert("New Student Registered", $"Name: {student.StudentName}\nStudent Id:{student.StudentId}", "Ok");

            _studentRepository.AddStudent(student);
			_studentRepository.SaveStudents(_dataManager);

		}
		catch(Exception ex)
		{
			DisplayAlert("Invalid Input", $"{ex.Message}", "Ok");
		}
    }

    private void OnViewStudents(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new ViewAllStudentsPage(_studentRepository));
    }

    void OnAddCourse(System.Object sender, System.EventArgs e)
    {
    }
}
