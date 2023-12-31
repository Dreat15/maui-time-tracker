﻿using TimeTracker.Contracts.Services;

namespace TimeTracker.Views
{
    public class SecondPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public Command GoBackCommand
            => new Command(async () => await _navigationService.NavigateBack());

        public Command NextCommand
            => new Command(async () => await _navigationService.NavigateToThirdPage());

        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from SecondPage");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object? parameter)
        {
            Console.WriteLine($"On navigating to SecondPage with parameter {parameter}");
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            Console.WriteLine("On navigated to SecondPage");
            return base.OnNavigatedTo();
        }
    }
}
