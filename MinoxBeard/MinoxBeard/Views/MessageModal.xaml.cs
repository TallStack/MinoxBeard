using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageModal : PopupPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public MessageModal(string Message)
        {
            InitializeComponent();
            //MessageTxt.Text = Message;
        }

        private async void OkayClicked(object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
    }
}