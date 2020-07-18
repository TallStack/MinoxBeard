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
    public partial class RecordPage : ContentPage
    {
        private RecordViewModel _recordViewModel;
        public RecordPage()
        {
            _recordViewModel = ViewModelLocator.RecordViewModel;
            InitializeComponent();
            BindingContext = _recordViewModel;
        }

        async void ImageButton_Pressed(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new MessageModal("This feature is coming soon"), true);
        }
    }
}