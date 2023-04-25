namespace LearningManagementSystem.Views;

public partial class CourseListPage : ContentPage
{
	public CourseListPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<CourseListViewModel>();
        InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var viewModel = (CourseListViewModel)this.BindingContext;
        viewModel.DisplayCoursesCommand.Execute(null);
    }
}