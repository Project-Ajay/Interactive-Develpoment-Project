using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class ViewAllStudentsPage : ContentPage
{

	private StudentRepository _studentRepository;

	public StudentRepository StudentRepository => _studentRepository;

	private Student _selectedStudent;

	public Student SelectedStudent
	{
		get { return _selectedStudent; }
		set
		{
			if (_selectedStudent == value) return;
			_selectedStudent = value;
			OnPropertyChanged();
		}
	}

	public ViewAllStudentsPage(StudentRepository studentRepository)
	{
		InitializeComponent();
		_studentRepository = studentRepository;
		this.BindingContext = this;

	}

    void BackToAdmin(System.Object sender, System.EventArgs e)
    {
		Navigation.PopAsync();
    }
}
