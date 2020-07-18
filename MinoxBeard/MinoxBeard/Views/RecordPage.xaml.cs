using MinoxBeard.Helpers;
using MinoxBeard.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
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
            LoadUsage();
        }

        async void ImageButton_Pressed(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new MessageModal("This feature is coming soon"), true);
        }
        public async Task LoadUsage()
        {
            await _recordViewModel.GetDbUses();
            if(_recordViewModel.Count == 0)
                _recordViewModel.Usages = _recordViewModel.GetUses();
            else
                _recordViewModel.Usages = await _recordViewModel.GetDbUses();
            BindingContext = _recordViewModel;

        }
        private async Task OpenAnimation(View view, uint length = 250)
        {
            view.RotationX = -90;
            view.IsVisible = true;
            view.Opacity = 0;
            _ = view.FadeTo(1, length);
            await view.RotateXTo(0, length);
        }

        private async Task CloseAnimation(View view, uint length = 250)
        {
            _ = view.FadeTo(0, length);
            await view.RotateXTo(-90, length);
            view.IsVisible = false;
        }

        private async void MainExpander_Tapped(object sender, EventArgs e)
        {
            var expander = sender as Expander;
            var imgView = expander.FindByName<Grid>("ImageView");
            var detailsView = expander.FindByName<Grid>("DetailsView");

            if (expander.IsExpanded)
            {
                await OpenAnimation(imgView);
                await OpenAnimation(detailsView);
            }
            else
            {
                await CloseAnimation(detailsView);
                await CloseAnimation(imgView);
            }
        }

        async void ImageButton_Pressed_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecordPage());
        }
    }
}
