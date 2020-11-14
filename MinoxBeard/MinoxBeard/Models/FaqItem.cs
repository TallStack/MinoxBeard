using System;
using System.Collections.Generic;
using System.Text;

namespace MinoxBeard.Models
{
    public class FaqItem
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public int Price { get; set; }
        public string Icon { get; set; }
        public List<CarouselImage> Images { get; set; }
    }
}
