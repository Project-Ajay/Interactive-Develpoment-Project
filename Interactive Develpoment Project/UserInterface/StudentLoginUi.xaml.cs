namespace Interactive_Develpoment_Project.UserInterface;
using Logic;

public partial class StudentLoginUi : ContentPage
{
	public StudentLoginUi()
	{
		InitializeComponent();
		//Student student1 = new Student("Ajay Persaud","ajaypersaud04@gmail.com", new DateOnly(2004, 1, 1), "98723123",true);
	}

    private async void StudentLoginButton_Clicked(object sender, EventArgs e)
    {
		StudentInfoUi studentInfoUi = new StudentInfoUi();
		await Navigation.PushAsync(studentInfoUi);
    }
}