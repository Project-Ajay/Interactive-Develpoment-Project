namespace Interactive_Develpoment_Project.UserInterface;

public partial class StudentLoginUi : ContentPage
{
	public StudentLoginUi()
	{
		InitializeComponent();
	}

    private async void StudentLoginButton_Clicked(object sender, EventArgs e)
    {
		StudentInfoUi studentInfoUi = new StudentInfoUi();
		await Navigation.PushAsync(studentInfoUi);
    }
}