namespace LearningManagementSystem.Views;

public partial class StudentListPage : ContentPage
{
	public StudentListPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<StudentListViewModel>();
        InitializeComponent();
	}
}