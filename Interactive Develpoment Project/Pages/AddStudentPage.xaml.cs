using Interactive_Develpoment_Project.Logic;
namespace Interactive_Develpoment_Project.Pages;

public partial class AddStudentPage : ContentPage
{
	private List<Student> _students = new List<Student>();

	public AddStudentPage()
	{
		InitializeComponent();
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

			_students.Add(student);

		}
		catch(Exception ex)
		{
			DisplayAlert("Invalid Input", $"{ex.Message}", "Ok");
		}
    }

    private void OnViewStudents(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new StudentInfoUi());
    }
}
