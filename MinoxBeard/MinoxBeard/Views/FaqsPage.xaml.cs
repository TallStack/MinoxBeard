using MinoxBeard.Models;
using MinoxBeard.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FaqsPage : ContentPage
    {
        private readonly FaqViewModel viewModel;

        public FaqsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new FaqViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        private async void ItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (e.CurrentSelection.Count == 0)
                return;
            if (!(e.CurrentSelection.First() is FaqItem item))
                return;
            if (AppConstants.ShowAds)
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
            }
            await Navigation.PushAsync(new FaqsDetailPage(new FaqDetailViewModel(item)));

            // Manually deselect item.
            ItemsList.SelectedItem = null;
        }
    }
}
