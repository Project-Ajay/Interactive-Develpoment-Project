namespace Interactive_Develpoment_Project.Pages;

public partial class TeacherLoginUI : ContentPage
{
	public TeacherLoginUI()
	{
		InitializeComponent();
	}

    private void TeacherLoginButton_Clicked(object sender, EventArgs e)
    {

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
}