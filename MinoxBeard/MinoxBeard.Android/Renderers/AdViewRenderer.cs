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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(AdControlView),typeof(AdViewRenderer))]
namespace MinoxBeard.Droid.Renderers
{
    public class AdViewRenderer : ViewRenderer<AdControlView, AdView>
    {

        public AdViewRenderer(Context context) : base(context)
        {

        }
        string adUnitId = "ca-app-pub-5452051705648807/8530120426";
        AdSize adSize = AdSize.SmartBanner;
        AdView adView;
        private AdView CreateAdView()
        {
            if (adView != null)
                return adView;

            // This is a string in the Resources/values/strings.xml that I added or can be modified
            adView = new AdView(Context)
            {
                AdSize = adSize,
                AdUnitId = adUnitId
            };
            var adParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            adView.LayoutParameters = adParams;
            adView.LoadAd(new AdRequest.Builder().Build());

            return adView;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);
            if (Control == null && e.NewElement != null)
            {
                SetNativeControl(CreateAdView());
            }
        }
    }
}