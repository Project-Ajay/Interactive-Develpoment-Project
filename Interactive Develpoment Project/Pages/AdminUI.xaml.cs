//Yang's Page
using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class AdminUI : ContentPage
{
	public AdminUI()
	{
		InitializeComponent();
        AdminPageImage.Source = ImageSource.FromFile("admin.png");
	}

    private void OnRegisterStudent(System.Object sender, System.EventArgs e)
    {
        AddStudentPage addStudentPage = new AddStudentPage();
        Navigation.PushAsync(addStudentPage);
    }

    private void OnRegisterCourse(System.Object sender, System.EventArgs e)
    {
    }

    private void OnRegisterTeacher(object sender, EventArgs e)
    {
        AddTeacherPage addTeacherPage = new AddTeacherPage();
        Navigation.PushAsync(addTeacherPage);
    }
}
