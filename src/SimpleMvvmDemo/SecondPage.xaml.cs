using TimeTracker.Views;

namespace TimeTracker;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

