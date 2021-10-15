using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcWatches.Data;
using System;
using System.Linq;

namespace MvcWatches.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MvcWatchesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcWatchesContext>>()))
            {
                if (context.Watch.Any())
                {
                    return;
                }

                context.Watch.AddRange(
                    new Watch
                    {
                        Name = "Roleax",
                        Model= "GMT-Master II",
                        Size = 40,
                        MadeIn = "Made in Switzerland",
                        Rating = "4.5",
                        Price = 62803M
                    },

                    new Watch
                    {
                        Name = "Omega",
                        Model = "Speedmaster Date",
                        Size = 40,
                        MadeIn = "Made in Switzerland",
                        Rating = "3.5",
                        Price = 6342M
                    },

                    new Watch
                    {
                        Name = "Chopard",
                        Model = "Mille Miglia",
                        Size = 43,
                        MadeIn = "Made in Germany",
                        Rating = "4",
                        Price = 8758M
                    },

                    new Watch
                    {
                        Name = "Piaget",
                        Model = "Gouverneur",
                        Size = 33,
                        MadeIn = "Made in Switherland",
                        Rating = "4",
                        Price = 8960M
                    },

                    new Watch
                    {
                        Name = "Jaeger-LeCoultre",
                        Model = "Master Compressor GMT",
                        Size = 42,
                        MadeIn = "Made in Switherland",
                        Rating = "5",
                        Price = 18842M
                    },

                    new Watch
                    {
                        Name = "TAG Heuer",
                        Model = "Aquaracer 300M",
                        Size = 41,
                        MadeIn = "Made in Switherland",
                        Rating = "5",
                        Price = 2282M
                    },

                    new Watch
                    {
                        Name = "Cartier",
                        Model = "Ronde Jour et Nuit",
                        Size = 42,
                        MadeIn = "Made in Switherland",
                        Rating = "5",
                        Price = 24100M
                    },

                    new Watch
                    {
                        Name = "Audemars Piguet",
                        Model = "Royal Oak Offshore Chronograph",
                        Size = 43,
                        MadeIn = "Made in Switherland",
                        Rating = "5",
                        Price = 65429M
                    },

                    new Watch
                    {
                        Name = "Audemars Piguet",
                        Model = "Royal Oak Offshore Chronograph",
                        Size = 43,
                        MadeIn = "Made in Switherland ",
                        Rating = "4.5",
                        Price = 14591M
                    },

                    new Watch
                    {
                        Name = "IWC",
                        Model = "Pilot Chronograph Top Gun",
                        Size = 45,
                        MadeIn = "Made in Switzerland",
                        Rating = "4",
                        Price = 17218.25M
                    }


                    );
                context.SaveChanges();
            }
        }
    }
}
