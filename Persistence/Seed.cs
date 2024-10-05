using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedActivities(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Activity
                {
                    Title = "Future Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Activity
                {
                    Title = "Future Activity 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activity
                {
                    Title = "Future Activity 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };
            
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }

        public static async Task SeedSeasons(DataContext context)
        {
            if (context.Seasons.Any()) return;
            var seasons = new List<Season>
            {
                new Season {
                    Name = "Spring"
                },
                new Season {
                    Name = "Summer"
                },
                new Season {
                    Name = "Fall"
                },
                new Season {
                    Name = "Winter"
                }
            };
            await context.Seasons.AddRangeAsync(seasons);
            await context.SaveChangesAsync();
        }

         public static async Task SeedVillagers(DataContext context)
        {
            if (context.Villagers.Any()) return;
            var villagers = new List<Villager>
            {
                new Villager {
                    Name = "Alex",
                    BirthSeason = "Summer",
                    Birthday = 13,
                    Description = "Alex loves sports and hanging out at the beach. He is quite arrogant and brags to everyone that he is going to be a professional athlete. Is his cockiness just a facade to mask his crushing self-doubt? Is he using his sports dream to fill the void left by the disappearance of his parents? Or is he just a brazen youth trying to \'look cool?\'",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Elliot",
                    BirthSeason = "Summer",
                    Birthday = 9,
                    Description = "Elliott lives alone in a cabin on the beach. He is a writer who dreams of one day writing a magnificent novel. He is a sentimental “romantic” with a tendency to go off onto flowery, poetic tangents. When he can afford it, he enjoys a strong beverage at the Stardrop Saloon. Could a humble farmer such as yourself be the inspiration Elliott is looking for? There’s only one way to find out…",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Harvey",
                    BirthSeason = "Winter",
                    Birthday = 14,
                    Description = "Harvey is the town doctor. He\'s a little old for a bachelor, but he has a kind heart and a respected position in the community. He lives in a small apartment above the medical clinic, but spends most of his time working. You can sense a sadness about him, as if there\'s something he\'s not telling you…",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Sam",
                    BirthSeason = "Summer",
                    Birthday = 17,
                    Description = "Sam is an outgoing, friendly guy who is brimming with youthful energy. He plays guitar and drums, and wants to start a band with Sebastian as soon as he has enough songs together. However, he does have a habit of starting ambitious projects and not finishing them. Sam is a little stressed about the impending return of his father, who has been away for years due to his line of work.",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Sebastian",
                    BirthSeason = "Winter",
                    Birthday = 10,
                    Description = "Sebastian is a rebellious loner who lives in his parents\' basement. He is Maru\'s older half-brother, and feels like his sister gets all the attention and adoration, while he is left to rot in the dark. He tends to get deeply absorbed in his work, computer games, comic books, sci-fi novels, and will sometimes spend great lengths of time pursuing these hobbies alone in his room. He can be a bit unfriendly to people he doesn\'t know. Could a charming new farmer cultivate the wasteland of his heart? Who knows?",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Shane",
                    BirthSeason = "Spring",
                    Birthday = 20,
                    Description = "I'm renting my room from Marnie at a really good price. It's small but I can't complain. If I could reset my life maybe I'd start a chicken farm. Only free-range eggs of course.",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Abigail",
                    BirthSeason = "Fall",
                    Birthday = 13,
                    Description = "Abigail lives at the general store with her parents. She sometimes fights with her mom, who worries about Abigail\'s \"alternative lifestyle\". Her mom has the following to say: \"I wish Abby would dress more appropriately and stop dyeing her hair blue. She has such a wonderful natural hair color, just like her grandmother did. Oh, and I wish she\'d find some wholesome interests instead of this occult nonsense she's into.\" You might find Abigail alone in the graveyard, or maybe out in a rainstorm looking for frogs.",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Emily",
                    BirthSeason = "Spring",
                    Birthday = 27,
                    Description = "I'm just working at Gus' to make ends meet... but my real passion is tailoring. I made these clothes from scratch.",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Haley",
                    BirthSeason = "Spring",
                    Birthday = 14,
                    Description = "Being wealthy and popular throughout high school has made Haley a little conceited and self-centered. She has a tendency to judge people for superficial reasons. But is it too late for her to discover a deeper meaning to life? Is there a fun, open-minded young woman hidden within that candy-coated shell?",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Leah",
                    BirthSeason = "Winter",
                    Birthday = 23,
                    Description = "Leah lives alone in a small cabin just outside of town. She loves to spend time outside, foraging for a wild meal or simply enjoying the gifts of the season. She\'s a talented artist with a large portfolio of work… yet she\'s too nervous to display it to the public. Maybe you can give her a little confidence boost?",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Maru",
                    BirthSeason = "Summer",
                    Birthday = 10,
                    Description = "Growing up with a carpenter and a scientist for parents, Maru acquired a passion for creating gadgets at a young age. When she isn\'t in her room, fiddling with tools and machinery, she sometimes does odd jobs at the local clinic. Friendly, outgoing, and ambitious, Maru would be quite a lucky match for a lowly newcomer such as yourself… Can you win her heart, or will she slip through your fingers and disappear from your life forever?",
                    IsMarriageCandidate = true
                },
                new Villager {
                    Name = "Penny",
                    BirthSeason = "Fall",
                    Birthday = 2,
                    Description = "Penny lives with her mom, Pam, in a little trailer by the river. While Pam is out carousing at the saloon, Penny quietly tends to her chores in the dim, stuffy room she is forced to call home. She is shy and modest, without any grand ambitions for life other than settling in and starting a family. She likes to cook (although her skills are questionable) and read books from the local library.",
                    IsMarriageCandidate = true
                }
            };
            await context.Villagers.AddRangeAsync(villagers);
            await context.SaveChangesAsync();
        }
    
    }
}