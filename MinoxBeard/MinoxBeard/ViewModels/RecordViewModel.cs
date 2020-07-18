using MinoxBeard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MinoxBeard.ViewModels
{
    public class RecordViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<UsageModel> Usages { get; set; }
        public ObservableCollection<UsageModel> GetUses()
        {
            return new ObservableCollection<UsageModel>
            {
                new UsageModel { Title = "No record Uses yet", Image = "header", Venue = "Add your first use now", Duration = "", Date = DateTime.Now, Description = "Nothing to show here"}
            };
        }
    }
}
