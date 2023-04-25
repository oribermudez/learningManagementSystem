namespace LearningManagementSystem.Views;

public partial class CourseListPage : ContentPage
{
    public CourseListPage()
    {
        BindingContext = App.Current.Services.GetRequiredService<CourseListViewModel>();
        InitializeComponent();
    }
}