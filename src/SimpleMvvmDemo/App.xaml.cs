using TimeTracker.Contracts.Services;

namespace TimeTracker;

public partial class App : Application
{
	public App(INavigationService navigationService)
	{
		InitializeComponent();
		MainPage = new NavigationPage();
		navigationService.NavigateToMainPage();
	}
}
