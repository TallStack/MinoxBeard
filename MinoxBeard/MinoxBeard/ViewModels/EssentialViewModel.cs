using MinoxBeard.Models;
using MinoxBeard.Views;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MinoxBeard.ViewModels
{
    public class EssentialViewModel : BaseViewModel
    {
        public EssentialViewModel()
        {
            GetOnlineData();
        }

        public VideoModel FeaturedMovie => WatchList?.Where(x => x.IsFeatured == true).FirstOrDefault();


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

        private ObservableCollection<VideoModel> watchList;
        public ObservableCollection<VideoModel> WatchList
        {
            get { return watchList; }
            set
            {
                watchList = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FeaturedMovie));
            }
        }

        public ICommand SelectionCommand => new Command(() =>
        {
            if (selectedMovie != null)
            {
                var vm = new EssentialDetailsViewModel { SelectedMovie = selectedMovie };
                var page = new EssentialDetailsPage { BindingContext = vm };
                Application.Current.MainPage.Navigation.PushAsync(page);
            }
        });

        public ICommand PlayCommand => new Command(() =>
        {
            if (FeaturedMovie != null)
            {
                var vm = new PlayerViewModel { SelectedMovie = FeaturedMovie };
                var page = new PlayerPage { BindingContext = vm };
                Application.Current.MainPage.Navigation.PushAsync(page);
            }
        });

        private async void GetOnlineData()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                //You are offline, notify the user
                
            }
            else
            {
                var client = new HttpClient();
                var result = await client.GetStringAsync("https://tallstack.github.io/Videos.json");
                WatchList = JsonConvert.DeserializeObject<ObservableCollection<VideoModel>>(result);
            }
           
        }
    }
}
