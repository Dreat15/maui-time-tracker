﻿using TimeTracker.Contracts.Services;

namespace TimeTracker.Views
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly IDataService _dataService;
        readonly INavigationService _navigationService;

        public Command NavigateCommand
            => new Command(async () => await _navigationService.NavigateToSecondPage("some id"));

        public MainPageViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
        }

        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from MainPage");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object? parameter)
        {
            Console.WriteLine($"On navigating to MainPage with parameter {parameter}");
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            Console.WriteLine("On navigated to MainPage");
            return base.OnNavigatedTo();
        }
    }
}
