using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class ViewTeachersPage : ContentPage
{
	private Teacher _selectedTeacher;

	public Teacher SelectedTeacher { get { return _selectedTeacher; } set {  _selectedTeacher = value; } }

	private TeacherRepository _teacherRepository;

	public TeacherRepository TeacherRepository
	{
		get { return _teacherRepository; }
	}

	public ViewTeachersPage()
	{
		InitializeComponent();

		_teacherRepository = TeacherRepository.Repository;

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

		bool choice = await DisplayAlert("Attention", $"Are you sure you would like to delete {_selectedTeacher.TeacherFirstName} from the database", "Yes", "No");

		if (choice)
		{
			_teacherRepository.DeleteTeacher(_selectedTeacher);
            await DisplayAlert("Success", $"Successfully Deleted {_selectedTeacher.TeacherFirstName} {_selectedTeacher.TeacherLastName} from the database", "Ok");

			TeachersListView.ItemsSource = null;
			TeachersListView.ItemsSource = _teacherRepository.Teachers;
            _selectedTeacher = null;
            TeachersListView.SelectedItem = null;
        }
		else
		{
            TeachersListView.SelectedItem = null;
        }
    }
}