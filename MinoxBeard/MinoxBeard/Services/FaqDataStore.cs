using MinoxBeard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoxBeard.Services
{
    public class FaqDataStore : IFaqDataStore<FaqItem>
    {
        readonly List<FaqItem> items;

        public FaqDataStore()
        {
            items = new List<FaqItem>()
            {
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "Minoxidil is a generic medication used for hair regrowth. It was originally developed for treating hypertension (high blood pressure) as an oral medication.",
                    Text = "What is Minoxidil?",
                    FullDescription = "Minoxidil is a hair regrowth solution that also works for hair growth. Note that regrowth and growth are different, as regrowth means that one had or is currently losing their hair. Patients taking the drug orally discovered that — as a side effect — it promoted hair growth on the body. Research has demonstrated, that if applied topically to the scalp as a creme or liquid, it would still grow hair for the majority of people using it. In the United States, over-the-counter versions contain 2% or 5% minoxidil at most, due to FDA regulations.",
                    Subtitle = "answer",
                    Price = 319
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "There's no set age, but we advise no one younger than 18 to use it. If you're young, see what you can grow before using minox.",
                    Text = "What Age Can I Start Using Minoxidil?",
                    FullDescription = "There's no set age, but we advise no one younger than 18 to use it. If you're young, see what you can grow before using minox. You may know somebody who is 16 years old with a full beard; this is an exception — there are not many 16 year olds that can grow full beards. Boys finish puberty at approximately 16-20 years old, with many going as far as 22 years old. Even then, many men cannot grow facial hair at these young ages and realize that their beard genetics kick in around their mid-twenties. Facial hair continues to develop throughout our lives, well into our 30s.  If you are over 18, feel free to make such a decision on your own after reading this FAQ thoroughly. ",
                    Subtitle = "answer",
                    Price = 521
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "No. The FDA in the United States of America has approved minoxidil only for use on the scalp. Because of this, the product directions instruct users to apply it only there.",
                    Text = "Is Minoxidil Intended for Use on Face?",
                    FullDescription = "No. The FDA in the United States of America has approved minoxidil only for use on the scalp. Because of this, the product directions instruct users to apply it only there. More specifically, it is meant only for the vertex of the scalp. Technically, companies selling minoxidil (such as Rogaine) are legally not allowed to advertise the product for any area of the body other than the vertex. This is simply due to the fact that it's the only area that has been tested. If, however, you apply the product to the face, which has better blood circulation and absorption than the scalp, the likelihood increases that minoxidil will find its way into your bloodstream. We also call this systemic, despite the product being topical. The risk of side effect may increase, including body hair in places other than your face.",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "When minoxidil enters your system, it can (and likely will) promote hair growth on the whole body.",
                    Text = "How Does Minoxidil Promote Body Hair When You Apply it to Your Face?",
                    FullDescription = "Body hair is inevitable, but if the hair does not mature into terminal hair, then it will likely go away. This happens whether you apply to your scalp as intended, or to the face. Systemic absorption. These new hairs are vellus and have a high probability of falling out once you cease minoxidil applications. In fact, many minoxidil beard users experience cessation of this extra hair even while continuing to apply the solution, several months in. ",
                    Subtitle = "answer",
                    Price = 319
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "Of course. It is a drug, after all. Although, most of the common side effects are fairly minor. ",
                    Text = "Does Minoxidil Have Any Side Effects?",
                    FullDescription = "The first few applications might make your skin feel itchy or irritated, and possibly a little red. This is common and usually disappears after a few days or couple of weeks as your body adjusts to the minoxidil. ",
                    Subtitle = "answer",
                    Price = 521
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Twice a day is recommended; once in the morning and once in the evening, roughly twelve hours apart",
                    Text = "How Often Should I Apply Minoxidil?",
                    FullDescription = "Since the human body can only metabolize a certain amount of minoxidil within a 24-hour period, more frequent applications than two per day is unnecessary. Although twice per day is recommended, it is not obligatory. Some TMBS members report increased sensitivity to minoxidil and can only take one application a day. Other members can only take one application per day due to their work schedules. While results can be expected sooner when applying twice daily, many TMBS members are reporting steady results with only one daily application. Many have completed their minoxidil journey with a single application per day. Summary: Twice per day, keeping applications 8-12 hours apart. More than that will not make it work any better, and may cause side effects.",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "1ml per application is recommended. ",
                    Text = "How Much Should I Use?",
                    FullDescription = "Liquid: there is a fill line on the dropper that comes with your supply. If you have a spray bottle, it may be 6 sprays. Read your packaging for directions. Foam: for most brands of foam, it is half a cap. Foligain and Qgain are exceptions, which is a single pump. If you are growing out a beard, more may be needed as it clings to the hair. This means you will potentially use up your supply faster. Wash or rinse your face prior to applying to ensure it and the and pores are clean, and apply the minoxidil either with your finger or dropper. ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Whether foam or liquid, it should stay on for at least 4 hours. Tests have shown 50% is absorbed in the first hour, and 75% by hour four.",
                    Text = "How Long Should I Leave Minoxidil On?",
                    FullDescription = "Whether foam or liquid, it should stay on for at least 4 hours. Tests have shown 50% is absorbed in the first hour, and 75% by hour four. Bear in mind that this study was conducted on the scalp, which is less absorbent than the face. However, it is the most accurate information we have, so it should be treated as the standard amount of time.",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "We use the minoxidil treatment until the new hair that we have gained have matured into terminal hair.",
                    Text = "How Long Should the Minoxidil Journey Be?",
                    FullDescription = "We use the minoxidil treatment until the new hair that we have gained have matured into terminal hair. If you cease the minoxidil treatment before the vellus hair have been replaced with coarse, mature hair, then that hair may fall out as if you never had them. Terminal hair, on the other hand, are permanent. Even without the continued use of minoxidil, your new beard will continue to grow like any other beard. You should plan on using minoxidil for anywhere from six months to two years, minimum. Three months is not enough for the vast majority of guys. If this is the case for someone, they are an exception and quite lucky. Some people find that they need more time than one year for the vellus hair to be replaced with terminal. Every person is different, and there is no way for us to guess how long your body will need for all your new facial hair to mature. People using for less than 6 months often report losing their gains. As long as it takes for the hair to mature. This is generally between one and two years, with six months being a fantastic, lucky individual. Assume you are not fantastically lucky, and have patience.",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "According to Rogaine, a clinical trial has shown some people may see results as early as 8 weeks (based on the scalp, of course). They go on to point out that it can take up to 16 weeks to see results. ",
                    Text = "How Long Until I See Results?",
                    FullDescription = "As a rough interpretation, if you see anything before 8 weeks, you are on the upper end of the responsive scale. Anything longer than 16 weeks with zero gains may indicate you are what many call a “slow gainer,” but people can still see improvement past this point. For perspective: 16 weeks = 3 months, 3 weeks. As previously expressed, there is no real catch-all time frame for seeing vellus, or for hair maturation. Furthermore, this is based on the scalp and there are other factors that may play a part, but this is the best we can do to benchmark gains. The majority of us using minoxidil for our beards report seeing the biggest improvements happening between months 2-3 and beyond. Patience is the key. Continued treatment brings continued new growth. You will not see all of your potential the moment you start seeing vellus sprout; more will come even months later. Some report that growth seems to stall for a couple weeks to a month, and then proceed to burst out with new growth. It takes at least 90 - 112 days to get an idea of whether the product will work at all for an individual.  Give it a good 2-3 months before getting worried you're not seeing anything.",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Minoxidil is mixed with an alcohol carrier and propylene gylcol, which are what is drying your face out. First, try to make it to four hours of having the application on, then wash or rinse your face. Afterward, feel free to apply a moisturizer. ",
                    Text = "My Face is Itching / Drying",
                    FullDescription = "Minoxidil is mixed with an alcohol carrier and propylene gylcol, which are what is drying your face out. First, try to make it to four hours of having the application on, then wash or rinse your face. Afterward, feel free to apply a moisturizer. The reason you want to apply your moisturizer after washing or rinsing your face is because you want it clean and flake-free. Water will help with the absorption of the oils contained in your moisturizing products. If you cannot get past dryness, you may want to opt for foam. Very few individuals get dry face from foam minoxidil, and most do not need to moisturize whatsoever after the four hours have elapsed. Rinse your face well after the application time has elapsed, then apply your moisturizer. Switch to foam if it gets to be too bad with liquid. ",
                    Subtitle = "answer",
                    Price = 743
                }
            };
        }

        public async Task<bool> AddItemAsync(FaqItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(FaqItem item)
        {
            var oldItem = items.Where((FaqItem arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((FaqItem arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<FaqItem> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<FaqItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
