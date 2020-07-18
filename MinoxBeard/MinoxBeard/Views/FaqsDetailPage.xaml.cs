using MinoxBeard.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FaqsDetailPage : ContentPage
    {
        FaqDetailViewModel viewModel;
       
        //private PancakeView previouslySelectedCategory;

        public FaqsDetailPage(FaqDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
            //previouslySelectedCategory = viewModel.Categories.First();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //var stuff = categoryItems.ToList();
            //categoryCollectionView.SelectedItem = viewModel.Categories.First();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await heartLabel.RotateTo(360, 500, Easing.SpringOut);
            //await heartLabel.RotateTo(0, 0);
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //var item = sender as PancakeView;

            //if (previouslySelectedCategory != null)
            //    await previouslySelectedCategory.FadeTo(0.2, 100);
            //await item.FadeTo(1, 400, Easing.SpringOut);

            //previouslySelectedCategory = item;
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new MessageModal("example"), true);
        }
    }
}