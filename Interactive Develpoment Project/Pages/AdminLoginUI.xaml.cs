namespace Interactive_Develpoment_Project.Pages;

public partial class AdminLoginUI : ContentPage
{
	public AdminLoginUI()
	{
		InitializeComponent();
	}

    private void AdminLoginButton_Clicked(object sender, EventArgs e)
    {
		string adminId = AdminIDEntry.Text;
		string passWord = AdminPasswordEntry.Text;
    }
}