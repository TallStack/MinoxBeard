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
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "So far, there are two different application forms that are known to the group. One is to mix it with Minoxidil Liquid, the other is to mix it with Nivea Soft cream.",
                    Text = "How do I use LCLT for beard growth?",
                    FullDescription = "With both, you should take pure LCLT powder and take about 2% of your carrier substance's weight to mix it in. Keep in mind that LCLT has a pretty strong, fishy smell. You can put some PEO into your Minox or Nivea to fix this. After mixing LCLT into Minox or Nivea, you can use either as you would normally. Minox twice a day, Nivea as needed, although it is recommended to use Nivea with LCLT at least once a day if you're not using Minox + LCLT.",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "It is important to choose a product that contains 100% pure L-Carnitine L-Tartrate. This is usually the case with LCLT powder. ",
                    Text = "Which LCLT products can I use?",
                    FullDescription = "Capsules (and some powder brands!) mostly contain extra ingredients like silicon dioxide or magnesium salts which are supposed to prevent the binding of LCLT to other substances. Since this is exactly what we're trying to achieve, it's best to avoid products that contain other ingredients than LCLT itself, even though they might work just as fine it'd be best to stay safe and choose pure LCLT. ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Say you're derma rolling 2 days a week with a 0.5mm, then follow this schedule: ",
                    Text = "Is there a schedule I should be following?",
                    FullDescription = "Monday: AM minox | PM Minox then wait 4 hours, roll. Tuesday: AM n/a | PM apply minox. Wednesday: AM minox | PM minox. Thursday: AM minox | PM minox then wait 4 hours, roll and just repeat ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Run it under hot water to get any dead skin/other materials off, then leave in an alcohol bath for about 5 minutes. ",
                    Text = "How do I disinfect/clean my dermaroller?",
                    FullDescription = "Let it completely dry before using. You can use any antiseptic; isopropyl alcohol is the cheapest and will get the job done. ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "While it's true that dermarolling will increase absorption of minoxidil, that is not the reason we do it, and it is an incredibly irresponsible thing to do. ",
                    Text = "Derma rolling to increase minoxidil absorption?",
                    FullDescription = "There is a common misconception that people tend to have with dermarolling, where they think that the purpose of it is to increase absorption of minoxidil. This is not the case. As stated above, we dermaroll to induce collagen synthesis, NOT to increase absorption. Not only will applying minoxidil directly after microneedling negate the purpose of doing it, you're also putting yourself in a position where side effects may become prominent. If you are going to derma roll, please wait AT LEAST 24 hours before applying minox.",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Before: Before using a dermaroller, you must cleanse your face with soap and water (preferably something with antibacterial qualities). This is very important since there is loads of bacteria that are present on your face that could cause a multitude of infections if it gets into your skin.  ",
                    Text = "What to Do Before/After Using the dermaroller?",
                    FullDescription = "After: Because dermarolling creates hundreds of tiny micro cuts (to stimulate collagen production), it means that you're exposing your skin to outside germs and bacteria. Think of your face as one giant cut that needs to be protected against infection. That's why it's recommended to use an antibacterial ointment after you dermaroll to prevent this from happening ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Shaving or trimming low is recommended because the needles need to be able to puncture the skin for dermarolling to work. ",
                    Text = "Do I have to shave or trim before using the dermaroller?",
                    FullDescription = "If you have long growth and roll over it, you will only be damaging and pulling hair. Trimming is safer and carries less risk of causing irritation to the skin and hair follicles as opposed to shaving.  ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "1 mm can be used every two - four weeks on the same skin area. ",
                    Text = "How often can I use the dermaroller?",
                    FullDescription = "0.2 or 0.25 mm long needles can be used every second day on the same skin area.*(not sufficient for beard growth). 0.5 mm long needles can be used once or twice per week on the same skin area. ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Dermarolling jump starts the processes of collagen synthesis, something minoxidil inhibits (in vitro). Collagen is extremely vital to skin strength, thickness, and elasticity. ",
                    Text = "How can it help with your beard?",
                    FullDescription = "Dermarolling also stimulates your follicles, bringing more nutrients and blood to the area than minoxidil alone. ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "A dermaroller is a product that re-molds the skin by creating thousands of microscopic channels through the skin, increasing the formation of new tissue by activating the body's wound-healing mechanism.  ",
                    Text = "What is a dermaroller and what does it do?",
                    FullDescription = "CAUTION: If you decide to use a derma roller, please be advised that it can increase the side effects of minoxidil if used incorrectly. ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "While it is true that DHT is one of the leading causes of hair loss. This is only true for men who are predisposed to male pattern baldness. Men suffering from MPB are sensitive to even normal levels of DHT",
                    Text = "I Heard DHT Causes Baldness",
                    FullDescription = "Increasing your DHT levels will not cause you to go bald unless you are already predisposed to losing your hair from MPB. In which case, you're going to lose your hair eventually either way. Whether or not increasing your DHT levels will accelerate hair loss remains to be seen and cannot be answered at this time.  ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Shaving with a smooth face or trimming to a short length makes treatment easiest and least wasteful of the minoxidil. There is no correlation with shaving and growth results. ",
                    Text = "Should I Shave or Trim?",
                    FullDescription = "Remember that balding men are able to keep progress going on their scalps even with all of the hair there. These people also have genetics working against them, as balding is an ongoing, lifelong process. Shaving can help exfoliate the skin by a process known as derma-planing. It's simply straight-edged blade to remove excess dead skin cells. While it can help with exfoliation, shaving can also irritate the skin and can lead to ingrown hairs which can (in rare cases if left untreated) lead to infection.   ",
                    Subtitle = "answer",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Many of us recommend keeping it “basik.” Don't worry about the supplementation aspect of things. Rather, focus on minoxidil. If you wish to supplement, it's totally fine. But don't assume supplementation will drastically up your gains. ",
                    Text = "What Supplements Should I Take?",
                    FullDescription = "You should certainly try to get good nutrients from your diet, but if you believe you may have gaps in nutrition, take a multivitamin. While many people may recommend vitamins like biotin or diatomaceous earth, they will do nothing to improve your facial hair situation. On the other hand, if you're deficient in vitamins, those may very well be of great help to you. Sleep and low stress are big contributors to happy, healthy hair.  ",
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
