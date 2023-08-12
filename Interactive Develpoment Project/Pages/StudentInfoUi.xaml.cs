using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class StudentInfoUi : ContentPage
{
	private StudentRepository _studentRepository;
	public StudentInfoUi(StudentRepository studentRepository)
	{
		InitializeComponent();
		_studentRepository = studentRepository;

		
	}

}