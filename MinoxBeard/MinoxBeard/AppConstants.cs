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

        public static string InterstitialAdId
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-5452051705648807/4246388342";
                    default:
                        return "ca-app-pub-5452051705648807/4246388342";
                }
            }
        }
        private static int _counter;
        public static bool ShowAds
        {
            get
            {
                _counter++;
                if(_counter % 6 == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
    
    static class IconFonts
    {
        public const string Heart = "\uf2d1";
        public const string HeartOutline = "\uf2d5";
        public const string Star = "\uf4ce";
        public const string StarOutline = "\uf4d2";
        public const string Eye = "\uf208";
        public const string Candycane = "\uf10a";
        public const string Bus = "\uf0e7";
        public const string Mountain = "\uf2f5";
        public const string Map = "\uf34d";
        public const string Food = "\uf2f8";
        public const string Tour = "\uf2d1";
        public const string SignDirection = "\uf780";
    }
}
