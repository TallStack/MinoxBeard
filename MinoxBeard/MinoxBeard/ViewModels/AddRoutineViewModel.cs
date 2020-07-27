using MinoxBeard.Models;
using MinoxBeard.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MinoxBeard.ViewModels
{
    public class AddRoutineViewModel : INotifyPropertyChanged
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
        private string _daytype;
        private TimeSpan _time;



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
        
        public string DayType
        {
            get { return _daytype; }
            set { _daytype = value; NotifyPropertyChanged("DayType"); }
        } 
        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; NotifyPropertyChanged("Time"); }
        }

        public async Task<bool> SaveRoutine()
        {
            DateTime dateTime = DateTime.Now;

            if (!string.IsNullOrEmpty(_applicationType) || !string.IsNullOrEmpty(_note) || !string.IsNullOrEmpty(_daytype) || _time == null)
            {
                RoutineModel routine = new RoutineModel()
                {
                    RoutineType = _applicationType,
                    Date = DateTime.Now,
                    Color = "Gold",
                    DaySelection = _daytype,
                    Time = _time,
                    Notes = _note,
                    MoreInfos = new ObservableCollection<MoreInfo>{ new MoreInfo { Notes = _note, Time = _time }}

                };

                //Add New Usage  
                await App.SQLiteDb.SaveItemAsync(routine);
                ApplicationType = string.Empty;
                Note = string.Empty;
                DayType = string.Empty;
                await PopupNavigation.Instance.PushAsync(new MessageModal("Added Routine"), true);
                return true;
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new MessageModal("Whoops!! Please try again"), true);
                return false;
            } 
        }
    }
}

