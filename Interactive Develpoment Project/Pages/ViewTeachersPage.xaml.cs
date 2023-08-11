using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class ViewTeachersPage : ContentPage
{
	private TeacherRepository _teacherRepository;

	public TeacherRepository TeacherRepository { get { return _teacherRepository; } }
	public ViewTeachersPage(TeacherRepository teacherRepository)
	{
		InitializeComponent();

		_teacherRepository = teacherRepository;

		BindingContext = this;
	}

    private void BackBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}