namespace Interactive_Develpoment_Project.Pages;

public partial class StudentInfoUi : ContentPage
{
	string StudentId;
	public StudentInfoUi(string studentId)
	{
		InitializeComponent();
		StudentId = studentId;
	}

}