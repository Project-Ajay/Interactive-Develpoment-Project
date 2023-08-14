using Interactive_Develpoment_Project.Logic;

namespace Interactive_Develpoment_Project.Pages;

public partial class TeacherDashboardPage : ContentPage
{
    CourseRepository _courseRepository = new CourseRepository();

    CourseRepository CourseRepository => _courseRepository;

    public TeacherDashboardPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    private void CreateAssignmentButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            string assignmentTitle = TitleEntry.Text;
            string assignmentDescription = DescriptionEditor.Text;
            DateOnly assignmentDueDate = DateOnly.FromDateTime(DueDatePicker.Date);
            float assignmentweight = float.Parse(WeightEntry.Text);
            Course selectedCourse = CoursesPicker.SelectedItem as Course;

            if (selectedCourse == null)
            {
                DisplayAlert("Error", "Please select a course", "OK");
                return;
            }

            Assignment newAssignment = new Assignment(assignmentTitle, assignmentDescription, DateOnly.FromDateTime(DateTime.Now), 0.0, assignmentDueDate);
            selectedCourse.AddAssessment(newAssignment);

            DisplayAlert("Success", "Assignment created successfully", "OK");
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
