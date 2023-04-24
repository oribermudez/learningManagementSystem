namespace LearningManagementSystem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(StudentListPage), typeof(StudentListPage));
        Routing.RegisterRoute(nameof(AddStudentPage), typeof(AddStudentPage));
    }
}
