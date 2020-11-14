using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace MinoxBeard.Models
{
    public class RoutineModel
    {
        [PrimaryKey, AutoIncrement]
        public int RoutineID { get; set; }
        public string RoutineType { get; set; }
        public string DaySelection { get; set; }
        public TimeSpan Time { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public string Color { get; set; }
        [OneToMany]
        public ObservableCollection<MoreInfo> MoreInfos { get; set; }
    }

    public class MoreInfo 
    {
        [PrimaryKey, AutoIncrement]
        public int MoreInfoID { get; set; }
        public TimeSpan Time { get; set; }
        public string Notes { get; set; }
    }
}
