namespace LearningManagementSystem.Views;

public partial class AddCoursePage : ContentPage
{
    public AddCoursePage()
    {
        BindingContext = App.Current.Services.GetRequiredService<CourseViewModel>();
        InitializeComponent();
    }
}