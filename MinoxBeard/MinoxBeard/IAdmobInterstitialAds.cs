using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MinoxBeard
{
    public interface IAdmobInterstitialAds
    {
        Task Display(string AdId);
    }
}
