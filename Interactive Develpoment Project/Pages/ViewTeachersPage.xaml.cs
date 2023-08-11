using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class ViewTeachersPage : ContentPage
{
	private Teacher _selectedTeacher;

	public Teacher SelectedTeacher { get { return _selectedTeacher; } set {  _selectedTeacher = value; } }

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

    private async void DeleteBtn_Clicked(object sender, EventArgs e)
    {
		if (SelectedTeacher == null)
		{
			await DisplayAlert("Attention", "Select a teacher you would like to delete from the database", "OK");
			return;

        }

		bool choice = await DisplayAlert("Attention", $"Are you sre you would like to delete {_selectedTeacher.TeacherFirstName} from the database", "Yes", "No");

		if (choice)
		{
			_teacherRepository.DeleteTeacher(_selectedTeacher);
            await DisplayAlert("Success", $"Successfully Deleted {_selectedTeacher.TeacherFirstName} {_selectedTeacher.TeacherLastName} from the database", "Ok");

            TeachersListView.SelectedItem = null;
            TeachersListView.ItemsSource = null;
            TeachersListView.ItemsSource = _teacherRepository.Teachers;
            _selectedTeacher = null;
		}
		else
		{
            TeachersListView.SelectedItem = null;
        }
    }
}