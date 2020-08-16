using MediaManager.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;


namespace MinoxBeard.ViewModels
{
    public class ProfileViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _name;
        private string _lastname;

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged("Name"); }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; NotifyPropertyChanged("LastName"); }
        }

        public void SaveName()
        {
            Preferences.Set("Name", Name);
            Preferences.Set("LastName", LastName);
        } 
        
        public void RemoveName()
        {
            Preferences.Remove("Name");
            Preferences.Remove("LastName");
        }

        public void LoadName()
        {
            Name = Preferences.Get("Name", "");
            LastName = Preferences.Get("LastName", "");
        }
    }
}
