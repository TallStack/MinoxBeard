using MinoxBeard.Helpers;
using MinoxBeard.ViewModels;
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
    public partial class AddRoutinePage : ContentPage
    {
        private AddRoutineViewModel _addroutineViewModel;
        public AddRoutinePage()
        {
            _addroutineViewModel = ViewModelLocator.AddRoutineViewModel;
            InitializeComponent();
            BindingContext = _addroutineViewModel;
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var check = await _addroutineViewModel.SaveRoutine();
            BindingContext = _addroutineViewModel;
            //TODO: fix for collection refresh 
            if (check)
                //await Navigation.PushAsync(new RoutinePage());
                await Navigation.PopAsync();


        }
    }
}