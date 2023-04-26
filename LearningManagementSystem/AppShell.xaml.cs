namespace LearningManagementSystem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(StudentListPage), typeof(StudentListPage));
        Routing.RegisterRoute(nameof(AddStudentPage), typeof(AddStudentPage));
        Routing.RegisterRoute(nameof(EditStudentPage), typeof(EditStudentPage));
        Routing.RegisterRoute(nameof(CourseListPage), typeof(CourseListPage));
        Routing.RegisterRoute(nameof(LandingPage), typeof(LandingPage));
    }
}
