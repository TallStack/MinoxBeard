using MinoxBeard.Controls;
using MinoxBeard.Helpers;
using MinoxBeard.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutinePage : ContentPage
    {
        private RoutineViewModel _routineViewModel;
        public RoutinePage()
        {
            _routineViewModel = ViewModelLocator.RoutineViewModel;
            InitializeComponent();
            LoadRoutine();
        }
        protected async override void OnAppearing()
        {
            await LoadRoutine();
        }
        public async Task LoadRoutine()
        {
            await _routineViewModel.GetDbRoutines();
            _routineViewModel.Routines = await _routineViewModel.GetDbRoutines();
            BindingContext = _routineViewModel;

        }


        async void ImageButton_Pressed_1(object sender, EventArgs e)
        {
            if (AppConstants.ShowAds)
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
            }
            await Navigation.PushAsync(new AddRoutinePage());
        }
    }

}