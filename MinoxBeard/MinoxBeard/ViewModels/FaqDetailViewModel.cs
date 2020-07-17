using MinoxBeard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MinoxBeard.ViewModels
{
    public class FaqDetailViewModel : BaseViewModel
    {
        public FaqItem Item { get; set; }
        public ObservableCollection<CarouselImage> CarouselImages { get; set; }

        public FaqDetailViewModel(FaqItem item = null)
        {
            Title = item?.Text;
            Item = item;
            Description = item?.FullDescription;

            CarouselImages = new ObservableCollection<CarouselImage>
            {
                new CarouselImage { Source = "beard1" },
                new CarouselImage { Source = "beard2" },
                new CarouselImage { Source = "beard3" }
            };
        }
    }
}
