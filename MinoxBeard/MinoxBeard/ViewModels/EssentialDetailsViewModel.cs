using MinoxBeard.Models;
using MinoxBeard.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MinoxBeard.ViewModels
{
    public class EssentialDetailsViewModel : BaseViewModel
    {
        private VideoModel selectedMovie;
        public VideoModel SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                OnPropertyChanged();
            }
        }

        public ICommand PlayCommand => new Command(() =>
        {
            var vm = new PlayerViewModel { SelectedMovie = selectedMovie };
            var page = new PlayerPage { BindingContext = vm };
            Application.Current.MainPage.Navigation.PushAsync(page);
        });
    }
}
