using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TinyMvvm;

namespace SampleApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand details;
        private ObservableCollection<string> names;

        public ICommand Details => details ?? new TinyCommand<string>(async (name) =>
        {
            await Navigation.NavigateToAsync($"{nameof(DetailsViewModel)}?name={name}", DateTimeOffset.Now);
        });

        public ObservableCollection<string> Names
        {
            get => names;
            set => Set(ref names, value);
        }

        public async override Task Initialize()
        {
            IsBusy = true;
            await base.Initialize();

            Names = new ObservableCollection<string>(new List<string>()
        {
            "Daniel",
            "Ella",
            "Willner"
        });

            IsBusy = false;
        }

        public override Task OnAppearing()
        {
            return base.OnAppearing();
        }

        public override Task OnDisappearing()
        {
            return base.OnDisappearing();
        }
    }
}