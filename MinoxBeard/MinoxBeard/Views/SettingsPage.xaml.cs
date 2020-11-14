using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PatchPage());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //await DisplayAlert("Title", "Body", "cancel");
            await PopupNavigation.Instance.PushAsync(new RecordModal(), true);
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new RoutineModal(), true);
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            if (AppConstants.ShowAds)
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
            }
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}