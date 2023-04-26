using System.Text.Json;

namespace LearningManagementSystem.Views;

public partial class EditStudentPage : ContentPage
{
	public EditStudentPage(Student student)
	{
        BindingContext = App.Current.Services.GetRequiredService<EditStudentViewModel>();
        var viewModel = (EditStudentViewModel)this.BindingContext;
        viewModel.SelectedStudent = student;
        InitializeComponent();
    }


}