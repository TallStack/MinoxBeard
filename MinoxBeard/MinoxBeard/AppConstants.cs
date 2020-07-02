using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MinoxBeard
{
    public class AppConstants
    {
        public static string AppId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-5452051705648807~1581568695";
                    default:
                        return "ca-app-pub-5452051705648807~1581568695";
                }
            }
        }
        public static string BannerId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-5452051705648807/8530120426";
                    default:
                        return "ca-app-pub-5452051705648807/8530120426";
                }
            }
        }
    }
}
