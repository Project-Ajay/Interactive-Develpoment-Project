namespace Interactive_Develpoment_Project.Pages;

public partial class AddStudentPage : ContentPage
{
	public AddStudentPage()
	{
		InitializeComponent();
	}

    private void AddStudent_Clicked(object sender, EventArgs e)
    {
		string studentName = StudentNameEnty.Text;
		string studentEmail = EmailEntry.Text;
		string studentPhoneNumber = PhoneNumberEntry.Text;
		string studentPassword = PasswordEntry.Text;
		DateOnly BirthDate;
		bool isDomesticStudent;
		bool isReqistered;


    }
}
