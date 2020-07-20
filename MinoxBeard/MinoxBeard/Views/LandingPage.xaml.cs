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
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }
        const uint AnimationSpeed = 300;

        protected override void OnAppearing()
        {
            base.OnAppearing();
           

        } 


        async void SlideShow_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());

        }

        private async void PageFader_Tapped(object sender, EventArgs e)
        {
          
            await PageFader.FadeTo(0, AnimationSpeed, Easing.SinInOut);
            PageFader.IsVisible = false;
        }

        //private void Artist_Tapped(object sender, EventArgs e)
        //{
        //    var pageHeight = Height;
           
        //    PageFader.IsVisible = true;
        //    PageFader.FadeTo(1, AnimationSpeed, Easing.SinInOut);
            
        //}
    }
}