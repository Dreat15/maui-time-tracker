using TimeTracker.Views;

namespace TimeTracker;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

