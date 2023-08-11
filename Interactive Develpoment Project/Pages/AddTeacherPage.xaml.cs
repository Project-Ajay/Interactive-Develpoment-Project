using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class AddTeacherPage : ContentPage
{
    private TeacherRepository _repository = new TeacherRepository();
	public AddTeacherPage()
	{
		InitializeComponent();
	}

    private async void AddTeacherBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            string firstname = firstNameEntry.Text;
            string lastname = lastNameEntry.Text;
            string email = emailEntry.Text;
            string phone = phoneEntry.Text;
            DateOnly dob = DateOnly.FromDateTime(dateofbirthEntry.Date);
            string password = passwordEntry.Text;

            Teacher teacher = new Teacher(firstname, lastname, email, phone, dob, password);
            _repository.CreateTeacher(teacher);

            await DisplayAlert("Teacher Created", $"Log in details\n\nLogin ID: {teacher.TeacherId}\nPassword: {teacher.Password}", "Ok");

            firstNameEntry.Text = "";
            lastNameEntry.Text = "";
            emailEntry.Text = "";
            phoneEntry.Text = "";
            dateofbirthEntry.Date = DateTime.Now;
            passwordEntry.Text = "";
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Ok");
        }
    }

    private void ViewTeachersBtn_Clicked(object sender, EventArgs e)
    {

    }

    private async void BackBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}