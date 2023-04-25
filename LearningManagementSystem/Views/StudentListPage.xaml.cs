using System.Windows.Input;

namespace LearningManagementSystem.Views;

public partial class StudentListPage : ContentPage
{
	public StudentListPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<StudentListViewModel>();
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var viewModel = (StudentListViewModel)this.BindingContext;
        viewModel.DisplayStudentsCommand.Execute(null);
    }
}