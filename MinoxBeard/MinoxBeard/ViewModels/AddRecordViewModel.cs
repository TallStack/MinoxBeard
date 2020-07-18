using MinoxBeard.Models;
using MinoxBeard.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MinoxBeard.ViewModels
{
    public class AddRecordViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _applicationType;
        private string _note;



        public string ApplicationType
        {
            get { return _applicationType; }
            set { _applicationType = value; NotifyPropertyChanged("ApplicationType"); }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; NotifyPropertyChanged("Note"); }
        }

        public async Task SaveUsage()
        {
            DateTime dateTime = DateTime.Now;
            var timeApp = "";
            DateTime timeOfDayGreeting = DateTime.Now;

            if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12)
            {
                timeApp = "Morning Application";
            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 18)
            {
                timeApp = "Afternoon Application";
            }
            else if (timeOfDayGreeting.Hour >= 19 && timeOfDayGreeting.Hour < 23)
            {
                timeApp = "Night Time Application";
            }
            else
            {
                timeApp = "Midnight Application";
            }
            if (!string.IsNullOrEmpty(_applicationType) || !string.IsNullOrEmpty(_note))
            {
                UsageModel usage = new UsageModel()
                {
                    Title = _applicationType,
                    Description = _note,
                    Date = DateTime.Now,
                    Image = "header",
                    Duration = dateTime.ToString("hh:mm tt"),
                    Venue = timeApp

                };

                //Add New Usage  
                await App.SQLiteDb.SaveItemAsync(usage);
                ApplicationType = string.Empty;
                Note = string.Empty;
                await PopupNavigation.Instance.PushAsync(new MessageModal("Added Record"), true);

            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new MessageModal("Whoops!! Please try again"), true);
            }
        }
    }
}
