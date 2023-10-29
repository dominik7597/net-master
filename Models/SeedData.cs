using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGame.Data;
using System;
using System.Linq;

namespace MvcGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcGameContext>>()))
            {
                // Look for any games.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                // Look for any publishers.
                if (context.Publisher.Any())
                {
                    return;   // DB has been seeded
                }

                context.Publisher.AddRange(
                    new Publisher
                    {
                        Name = "Eidos Interactive",
                        Rating = "A",
                        Country = "UK"

                    },
                    new Publisher
                    {
                        Name = "Ubisoft",
                        Rating = "B",
                        Country = "France"
                    },
                    new Publisher
                    {
                        Name = "CD Projekt RED",
                        Rating = "A",
                        Country = "Poland"
                    },
                    new Publisher
                    {
                        Name = "Rockstar Games",
                        Rating = "A",
                        Country = "USA"
                    }
                );
                context.SaveChanges();

                context.Game.AddRange(

                    new Game
                    {
                        Title = "Deus Ex",
                        ReleaseDate = DateTime.Parse("2000-6-23"),
                        Genre = "RPG",
                        Rating = "R",
                        Price = 4.99M,
                        PublisherId = 1
                    },

                    new Game
                    {
                        Title = "Splinter Cell",
                        ReleaseDate = DateTime.Parse("2002-11-18"),
                        Genre = "Stealth",
                        Rating = "R",
                        Price = 4.99M,
                        PublisherId = 2
                    },

                    new Game
                    {
                        Title = "Witcher 3",
                        ReleaseDate = DateTime.Parse("2015-5-19"),
                        Genre = "RPG",
                        Rating = "R",
                        Price = 29.99M,
                        PublisherId = 3
                    },

                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Genre = "Action Adventure",
                        Rating = "R",
                        Price = 39.99M,
                        PublisherId = 4
                    },

                    new Game
                    {
                        Title = "Tom Clancy’s Rainbow Six Siege",
                        ReleaseDate = DateTime.Parse("2015-12-1"),
                        Genre = "FPS",
                        Rating = "R",
                        Price = 29.99M,
                        PublisherId = 2
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
