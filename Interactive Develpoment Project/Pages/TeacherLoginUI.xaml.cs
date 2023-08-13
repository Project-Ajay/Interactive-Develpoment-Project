using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class TeacherLoginUI : ContentPage
{
    private TeacherRepository _teacherRepository = new TeacherRepository();

    public TeacherLoginUI()
    {
        InitializeComponent();

        _teacherRepository = TeacherRepository.Repository;
    }

    private async void TeacherLoginButton_Clicked(object sender, EventArgs e)
    {
        string teacherId = TeacherIDEntry.Text;
        string password = TeacherPasswordEntry.Text;

        Teacher teacher = _teacherRepository.FindTeacherById(teacherId);

        if(teacher != null && teacher.Password == password)
        {
            await DisplayAlert("Login Successful", $"Welcome, {teacher.TeacherFirstName}", "Ok");
        }
        else
        {
            await DisplayAlert("", "\t\t‼️\n\n\tInvalid ID or Password", "Ok");
            TeacherPasswordEntry.Text = "";
        }
    }

    private void showPassword_clicked(object sender, EventArgs e)
    {
        //If the image button is clicked it will change the image and show/hide the text.
        //found the property "IsPassword" here: https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.entry.ispassword?view=net-maui-7.0.
        if (TeacherPasswordEntry.IsPassword==true)
        {
            TeacherPasswordEntry.IsPassword = false;
            showPasswordImageBtn.Source = "hidepassword.png";
            
        }
        else if (TeacherPasswordEntry.IsPassword == false)
        {
            TeacherPasswordEntry.IsPassword=true;
            showPasswordImageBtn.Source = "showpassword.png";
        }
    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddTeacherPage());
    }
}