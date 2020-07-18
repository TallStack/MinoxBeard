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
    public partial class RecordPage : ContentPage
    {
        private RecordViewModel _recordViewModel;
        public RecordPage()
        {
            _recordViewModel = ViewModelLocator.RecordViewModel;
            InitializeComponent();
            BindingContext = _recordViewModel;
        }
    }
}