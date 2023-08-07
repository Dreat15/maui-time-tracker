using TimeTracker.Contracts.Services;
using TimeTracker.Services;
using TimeTracker.Views;

namespace TimeTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddTransient<SecondPage>();
		builder.Services.AddTransient<SecondPageViewModel>();
		builder.Services.AddTransient<ThirdPage>();
		builder.Services.AddTransient<ThirdPageViewModel>();

		builder.Services.AddSingleton<IDataService, DataService>();
		builder.Services.AddSingleton<INavigationService, NavigationService>();

		return builder.Build();
	}
}
