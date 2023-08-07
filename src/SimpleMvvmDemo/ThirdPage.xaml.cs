using TimeTracker.Views;

namespace TimeTracker;

public partial class ThirdPage : ContentPage
{
	public ThirdPage(ThirdPageViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}

