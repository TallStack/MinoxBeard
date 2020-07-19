using MinoxBeard.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinoxBeard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoutinePage : ContentPage
    {
        public RoutinePage()
        {
            InitializeComponent();
            
        }

        //public ObservableCollection<Agenda> MyAgenda { get => GetAgenda(); }

        //private ObservableCollection<Agenda> GetAgenda()
        //{
        //    return new ObservableCollection<Agenda>
        //    {
        //        new Agenda { Topic = "All Things Xamarin", Duration = "07:30 UTC - 11:30 UTC", Color = "#B96CBD", Date = new DateTime(2020, 3, 23),
        //            Speakers = new ObservableCollection<Speaker>{ new Speaker { Name = "Maddy Leger", Time = "07:30" }, new Speaker { Name = "David Ortinau", Time = "08:30" }, new Speaker { Name = "Gerald Versluis", Time = "10:30" } } },

        //        new Agenda { Topic = "Visualize Your Data", Duration = "07:30 UTC - 11:30 UTC", Color = "#49A24D", Date = new DateTime(2020, 3, 24),
        //            Speakers = new ObservableCollection<Speaker>{ new Speaker { Name = "Maddy Leger", Time = "07:30" }, new Speaker { Name = "David Ortinau", Time = "08:30" }, new Speaker { Name = "Gerald Versluis", Time = "10:30" } } },

        //        new Agenda { Topic = "Testing Your Xamarin Apps", Duration = "07:30 UTC - 11:30 UTC", Color = "#FDA838", Date = new DateTime(2020, 3, 25),
        //            Speakers = new ObservableCollection<Speaker>{ new Speaker { Name = "Maddy Leger", Time = "07:30" }, new Speaker { Name = "David Ortinau", Time = "08:30" }, new Speaker { Name = "Gerald Versluis", Time = "10:30" } } },

        //        new Agenda { Topic = "Xamarin Productivity to the Max", Duration = "07:30 UTC - 11:30 UTC", Color = "#F75355", Date = new DateTime(2020, 3, 26),
        //            Speakers = new ObservableCollection<Speaker>{ new Speaker { Name = "Maddy Leger", Time = "07:30" }, new Speaker { Name = "David Ortinau", Time = "08:30" }, new Speaker { Name = "Gerald Versluis", Time = "10:30" } } },

        //        new Agenda { Topic = "All Things Xamarin.Forms Shell", Duration = "07:30 UTC - 11:30 UTC", Color = "#00C6AE", Date = new DateTime(2020, 3, 27),
        //            Speakers = new ObservableCollection<Speaker>{ new Speaker { Name = "Maddy Leger", Time = "07:30" }, new Speaker { Name = "David Ortinau", Time = "08:30" }, new Speaker { Name = "Gerald Versluis", Time = "10:30" } } },

        //        new Agenda { Topic = "Building Beautiful Apps", Duration = "07:30 UTC - 11:30 UTC", Color = "#455399", Date = new DateTime(2020, 3, 28),
        //            Speakers = new ObservableCollection<Speaker>{ new Speaker { Name = "Maddy Leger", Time = "07:30" }, new Speaker { Name = "David Ortinau", Time = "08:30" }, new Speaker { Name = "Gerald Versluis", Time = "10:30" } } }
        //    };
        //}

        async void ImageButton_Pressed(object sender, EventArgs e)
        {
            if (AppConstants.ShowAds)
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
            }
            await Navigation.PushAsync(new AddRoutinePage());
        }
    }


    //public class Agenda
    //{
    //    public string Topic { get; set; }
    //    public string Duration { get; set; }
    //    public DateTime Date { get; set; }
    //    public ObservableCollection<Speaker> Speakers { get; set; }
    //    public string Color { get; set; }
    //}

    //public class Speaker
    //{
    //    public string Name { get; set; }
    //    public string Time { get; set; }
    //}
}