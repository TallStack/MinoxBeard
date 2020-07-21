using MinoxBeard.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinoxBeard.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        private VideoModel selectedMovie;
        public VideoModel SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                OnPropertyChanged();
            }
        }
    }
}
