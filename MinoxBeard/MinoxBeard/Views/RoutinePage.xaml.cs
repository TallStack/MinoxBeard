using MinoxBeard.Controls;
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
    public partial class RoutinePage : ContentPage
    {
        public RoutinePage()
        {
            InitializeComponent();
            AdmobControl admobControl = new AdmobControl()
            {
                AdUnitId = AppConstants.BannerId
               // BackgroundColor = Color.Red
            };
            Label adLabel = new Label() { Text = "Ads will display here", HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand };

            Button ShowAd = new Button() { Text = "Show Ads", HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand };
            ShowAd.Clicked += ShowAd_Clicked;

            Content = new StackLayout()
            {
                Children =
                {
                    adLabel, ShowAd, admobControl
                }
            };

            async void ShowAd_Clicked(object sender, EventArgs e)
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
            }


        }
    }
}