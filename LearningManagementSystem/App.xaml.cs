namespace LearningManagementSystem;

public partial class App : Application
{
    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }

    public App()
	{
        var services = new ServiceCollection();
        Services = ConfigureServices(services);

        InitializeComponent();

		MainPage = new AppShell();
	}

    private static IServiceProvider ConfigureServices(IServiceCollection services)
    {
        // Viewmodels
        services.AddTransient<StudentListViewModel>();
        services.AddTransient<StudentViewModel>();
        services.AddTransient<EditStudentViewModel>();
        services.AddTransient<LandingViewModel>();
        services.AddTransient<CourseListViewModel>();


        // Views
        services.AddSingleton<StudentListPage>();
        services.AddSingleton<AddStudentPage>();
        services.AddSingleton<EditStudentPage>();
        services.AddSingleton<LandingPage>();
        services.AddSingleton<CourseListPage>();

        return services.BuildServiceProvider();
    }
}
