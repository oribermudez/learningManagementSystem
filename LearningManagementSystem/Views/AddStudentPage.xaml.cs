namespace LearningManagementSystem.Views;

public partial class AddStudentPage : ContentPage
{
	public AddStudentPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<StudentViewModel>();
        InitializeComponent();
	}
}