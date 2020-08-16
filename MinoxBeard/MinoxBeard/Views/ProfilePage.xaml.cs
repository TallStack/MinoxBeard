using MinoxBeard.Helpers;
using MinoxBeard.ViewModels;
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
    public partial class ProfilePage : ContentPage
    {
        private ProfileViewModel _profileViewModel;
        public ProfilePage()
        {
            _profileViewModel = ViewModelLocator.ProfileViewModel;
            InitializeComponent();
            _profileViewModel.LoadName();
            BindingContext = _profileViewModel;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            _profileViewModel.SaveName();
            await PopupNavigation.Instance.PushAsync(new MessageModal("All Saved!"), true);
            await Navigation.PopAsync();
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            _profileViewModel.RemoveName();
            await PopupNavigation.Instance.PushAsync(new MessageModal("All Cleared!"), true);
            await Navigation.PopAsync();
        }
    }
}