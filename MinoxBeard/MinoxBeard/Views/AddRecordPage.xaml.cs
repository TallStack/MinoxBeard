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
    public partial class AddRecordPage : ContentPage
    {
        private AddRecordViewModel _addrecordViewModel;
        public AddRecordPage()
        {
            _addrecordViewModel = ViewModelLocator.AddRecordViewModel;
            InitializeComponent();
            BindingContext = _addrecordViewModel;
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var check = await _addrecordViewModel.SaveUsage();
            BindingContext = _addrecordViewModel;
            //TODO: fix for collection refresh 
            if(check)
                await Navigation.PushAsync(new RecordPage());
            
           
        }
    }
}