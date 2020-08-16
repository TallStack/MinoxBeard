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
    public partial class RecordModal : PopupPage
    {
        public RecordModal()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await PopupNavigation.Instance.PushAsync(new RecordModal(), true);
             App.SQLiteDb.DeleteAllRecordsAsync();
            await PopupNavigation.Instance.PopAsync(true);
            CrossLocalNotifications.Current.Show("Beard Brother!", "All your records have been cleared", 0);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
    }
}