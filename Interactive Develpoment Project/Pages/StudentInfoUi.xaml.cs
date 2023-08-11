using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class StudentInfoUi : ContentPage
{
	private List<Student> _students;

	public StudentInfoUi(List<Student> students)
	{
		InitializeComponent();
		_students = students;
		
	}

}