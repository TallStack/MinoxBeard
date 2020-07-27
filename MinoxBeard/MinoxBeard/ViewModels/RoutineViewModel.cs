using MinoxBeard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MinoxBeard.ViewModels
{
    public class RoutineViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<RoutineModel> Routines { get; set; }


        public async Task<ObservableCollection<RoutineModel>> GetDbRoutines()
        {
            //Get All routines  
            var routineList = await App.SQLiteDb.GetRoutineItemsAsync();
            ObservableCollection<RoutineModel> myCollection = new ObservableCollection<RoutineModel>(routineList as List<RoutineModel>);
            if (routineList != null && routineList.Count > 0)
            {
                Routines = myCollection;
                return Routines;
            }
            return null;
        }

    }
}