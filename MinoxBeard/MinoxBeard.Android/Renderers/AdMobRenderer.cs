using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MinoxBeard.Controls;
using MinoxBeard.Droid.Renderers;
using Xamarin.Forms.Platform.Android;

[assembly:Xamarin.Forms.ExportRenderer(typeof(AdmobControl),typeof(AdMobRenderer))]
namespace MinoxBeard.Droid.Renderers
{
    public class AdMobRenderer : ViewRenderer<AdmobControl, AdView>
    {
        public AdMobRenderer(Context context) : base(context)
        {

        }
        private int GetSmartBannerDpHieght()
        {
            var dpHieght = Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density;
            if(dpHieght <= 400)
            {
                return 40;
            }
            if(dpHieght <= 720)
            {
                return 62;
            }
            return 102;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdmobControl> e)
        {
            base.OnElementChanged(e);

            if(Control == null)
            {
                var adView = new AdView(Context)
                {
                    AdSize = AdSize.SmartBanner,
                    AdUnitId = Element.AdUnitId
                };

                var requestbuilder = new AdRequest.Builder();
                adView.LoadAd(requestbuilder.Build());
                e.NewElement.HeightRequest = GetSmartBannerDpHieght();

                SetNativeControl(adView);
            }
        }
    }
}