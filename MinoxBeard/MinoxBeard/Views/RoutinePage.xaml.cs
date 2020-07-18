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
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
        }
    }
}