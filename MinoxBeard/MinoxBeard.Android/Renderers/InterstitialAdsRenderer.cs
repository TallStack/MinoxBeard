using System;
using System.Threading.Tasks;
using Android.Gms.Ads;
using MinoxBeard.Droid.Renderers;
using Xamarin.Forms;

[assembly: Dependency(typeof(InterstitialAdsRenderer))]
namespace MinoxBeard.Droid.Renderers
{
    public class InterstitialAdsRenderer :IAdmobInterstitialAds
    {
        public Task Display(string AdId)
        {
            var displyTask = new TaskCompletionSource<bool>();
            InterstitialAd AdInterstitial = new InterstitialAd(context: Forms.Context)
            {
                AdUnitId = AdId
            };
            {
                var adInterstitialListener = new AdInterstitialListener(AdInterstitial)
                {
                    AdClosed = () =>
                    {
                        if (displyTask != null)
                        {
                            displyTask.TrySetResult(AdInterstitial.IsLoaded);
                            displyTask = null;
                        }
                    },
                    AdFailed = () =>
                    {
                        if (displyTask != null)
                        {
                            displyTask.TrySetResult(AdInterstitial.IsLoaded);
                            displyTask = null;
                        }
                    }
                };
                AdRequest.Builder RequestBuilder = new AdRequest.Builder();
                AdInterstitial.AdListener = adInterstitialListener;
                AdInterstitial.LoadAd(RequestBuilder.Build());
            }
            return Task.WhenAll(displyTask.Task);
        }
    }

    public class AdInterstitialListener : AdListener
    {
        private readonly InterstitialAd _interstitialAd;

        public AdInterstitialListener(InterstitialAd interstitialAd)
        {
            _interstitialAd = interstitialAd;
        }

        public Action AdLoaded { get; set; }
        public Action AdClosed { get; set; }
        public Action AdFailed { get; set; }

        public override void OnAdLoaded()
        {
            base.OnAdLoaded();
            if(_interstitialAd.IsLoaded)
            {
                _interstitialAd.Show();
            }
            AdLoaded.Invoke();
        }

        public override void OnAdClosed()
        {
            base.OnAdClosed();
            AdClosed?.Invoke();
        }

        public override void OnAdFailedToLoad(int errorCode)
        {
            base.OnAdFailedToLoad(errorCode);
            AdFailed?.Invoke();
        }
    }
}