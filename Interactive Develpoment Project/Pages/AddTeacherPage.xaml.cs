using Interactive_Develpoment_Project.Logic;
using Interactive_Develpoment_Project.DataAccess;

namespace Interactive_Develpoment_Project.Pages;

public partial class AddTeacherPage : ContentPage
{
    private TeacherRepository _teacherRepository = new TeacherRepository();

    string _fileName = "project.json";

    IDataManager _dataManager;

	public AddTeacherPage()
	{
		InitializeComponent();

        _teacherRepository = TeacherRepository.Repository;

        //For Testing
        

        string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, _fileName);

        _dataManager = new DataJsonManager(filePath);
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
            _teacherRepository.CreateTeacher(teacher);

            _teacherRepository.SaveTeachers(_dataManager);

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

    private async void ViewTeachersBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewTeachersPage());
    }

    private async void BackBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}