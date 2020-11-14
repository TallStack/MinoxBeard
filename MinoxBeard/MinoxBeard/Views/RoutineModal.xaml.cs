using Plugin.LocalNotifications;
using Rg.Plugins.Popup.Pages;
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
    public partial class RoutineModal : PopupPage
    {
        public RoutineModal()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            App.SQLiteDb.DeleteAllRoutinesAsync();
            await PopupNavigation.Instance.PopAsync(true);
            CrossLocalNotifications.Current.Show("Beard Brother!", "All your routines have been cleared", 0);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
    }
}