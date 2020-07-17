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
                    Subtitle = "",
                    Price = 521
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "No. The FDA in the United States of America has approved minoxidil only for use on the scalp. Because of this, the product directions instruct users to apply it only there.",
                    Text = "Is Minoxidil Intended for Use on Face?",
                    Subtitle = "",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "When minoxidil enters your system, it can (and likely will) promote hair growth on the whole body.",
                    Text = "How Does Minoxidil Promote Body Hair When You Apply it to Your Face?",
                    Subtitle = "",
                    Price = 319
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.HeartOutline,
                    Description = "Of course. It is a drug, after all. Although, most of the common side effects are fairly minor. ",
                    Text = "Does Minoxidil Have Any Side Effects?",
                    Subtitle = "",
                    Price = 521
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Twice a day is recommended; once in the morning and once in the evening, roughly twelve hours apart",
                    Text = "How Often Should I Apply Minoxidil?",
                    Subtitle = "",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "1ml per application is recommended. ",
                    Text = "How Much Should I Use?",
                    Subtitle = "",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Whether foam or liquid, it should stay on for at least 4 hours. Tests have shown 50% is absorbed in the first hour, and 75% by hour four.",
                    Text = "How Long Should I Leave Minoxidil On?",
                    Subtitle = "",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "We use the minoxidil treatment until the new hair that we have gained have matured into terminal hair.",
                    Text = "How Long Should the Minoxidil Journey Be?",
                    Subtitle = "",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "According to Rogaine, a clinical trial has shown some people may see results as early as 8 weeks (based on the scalp, of course). They go on to point out that it can take up to 16 weeks to see results. ",
                    Text = "How Long Until I See Results?",
                    Subtitle = "",
                    Price = 743
                },
                new FaqItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Icon = IconFonts.Heart,
                    Description = "Minoxidil is mixed with an alcohol carrier and propylene gylcol, which are what is drying your face out. First, try to make it to four hours of having the application on, then wash or rinse your face. Afterward, feel free to apply a moisturizer. ",
                    Text = "My Face is Itching / Drying",
                    Subtitle = "",
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
