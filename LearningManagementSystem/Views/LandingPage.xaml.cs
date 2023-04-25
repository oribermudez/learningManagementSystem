namespace LearningManagementSystem.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<LandingViewModel>();
        InitializeComponent();
	}
}