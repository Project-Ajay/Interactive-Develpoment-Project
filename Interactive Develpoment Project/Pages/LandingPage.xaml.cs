using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    private void RegisterButton_Clicked(object sender, EventArgs e)
    {
        AdminUI adminUI = new AdminUI();
        Navigation.PushAsync(adminUI);
        
    }

    private void StudentButton_Clicked(object sender, EventArgs e)
    {
        StudentLoginUi studentLoginUi = new StudentLoginUi();
        Navigation.PushAsync(studentLoginUi);
    }

    private void TeacherButton_Clicked(object sender, EventArgs e)
    {
        TeacherLoginUI teacherLoginUI = new TeacherLoginUI();
        Navigation.PushAsync(teacherLoginUI);
    }
}