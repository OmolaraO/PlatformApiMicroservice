using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformSevice.Models;
using System;
using System.Linq;

namespace PlatformSevice.Data
{
    public static class PreparationDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data..");

                context.Platforms.AddRange(
                    new Platform() { Name = "DotNet", Publisher = "Microsoft",Cost="Free" },
                    new Platform() { Name = "Kuberentes", Publisher = "Cloud Native foundation", Cost="Free" },
                new Platform() { Name = "SqlServer Express", Publisher = "Microsoft", Cost="Free"}
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("-->We have data-->");
            }
        }
    }

}
