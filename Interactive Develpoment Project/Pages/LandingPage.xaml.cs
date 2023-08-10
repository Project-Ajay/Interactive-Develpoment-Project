namespace Interactive_Develpoment_Project.Pages;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    private void AdminButton_Clicked(object sender, EventArgs e)
    {
        AdminUI adminUI = new AdminUI();
        Navigation.PushAsync(adminUI);
    }

    private void StudentButton_Clicked(object sender, EventArgs e)
    {
        StudentLoginUi studentLoginUi = new StudentLoginUi();
        Navigation.PushAsync(studentLoginUi);
    }
}