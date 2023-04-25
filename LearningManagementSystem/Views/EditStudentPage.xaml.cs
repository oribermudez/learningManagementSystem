using System.Text.Json;

namespace LearningManagementSystem.Views;

public partial class EditStudentPage : ContentPage
{
	public EditStudentPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<StudentListViewModel>();
        InitializeComponent();
    }

}