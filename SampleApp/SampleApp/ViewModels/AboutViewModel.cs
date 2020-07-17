﻿using System.Windows.Input;
using TinyMvvm;

namespace SampleApp.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        private ICommand home;

        public ICommand Home => home ?? new TinyCommand(async () =>
        {
            await Navigation.NavigateToAsync("//home");
        });
    }
}