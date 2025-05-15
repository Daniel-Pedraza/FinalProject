using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Members.Any() || context.Pricings.Any() || context.Contacts.Any())
            return;

        // Seed Members
        context.Members.AddRange(
            new Member { Name = "Juan López", Bio = "Lead Violinist with 10 years of mariachi experience.", Photo = "/images/juan.jpg" },
            new Member { Name = "Carlos Rivera", Bio = "Trumpet player known for energetic solos.", Photo = "/images/carlos.jpg" },
            new Member { Name = "Miguel Torres", Bio = "Guitarist and vocalist with deep roots in Jalisco tradition.", Photo = "/images/miguel.jpg" },
            new Member { Name = "Ana María", Bio = "Talented harpist and singer.", Photo = "/images/ana.jpg" }
        );

        // Seed Pricing with realistic values by city
        context.Pricings.AddRange(
            // Amarillo (base city)
            new Pricing { Description = "Birthday Party (1 Hour)", Location = "Amarillo", Price = 250m },
            new Pricing { Description = "Wedding (2 Hours)", Location = "Amarillo", Price = 500m },
            new Pricing { Description = "Corporate Event (3 Hours)", Location = "Amarillo", Price = 700m },

            // Canyon (close by)
            new Pricing { Description = "Birthday Party (1 Hour)", Location = "Canyon", Price = 275m },
            new Pricing { Description = "Wedding (2 Hours)", Location = "Canyon", Price = 525m },
            new Pricing { Description = "Corporate Event (3 Hours)", Location = "Canyon", Price = 750m },

            // Lubbock
            new Pricing { Description = "Birthday Party (1 Hour)", Location = "Lubbock", Price = 350m },
            new Pricing { Description = "Wedding (2 Hours)", Location = "Lubbock", Price = 600m },
            new Pricing { Description = "Corporate Event (3 Hours)", Location = "Lubbock", Price = 850m },

            // Dallas
            new Pricing { Description = "Birthday Party (1 Hour)", Location = "Dallas", Price = 500m },
            new Pricing { Description = "Wedding (2 Hours)", Location = "Dallas", Price = 800m },
            new Pricing { Description = "Corporate Event (3 Hours)", Location = "Dallas", Price = 1150m },

            // Oklahoma City
            new Pricing { Description = "Birthday Party (1 Hour)", Location = "Oklahoma City", Price = 475m },
            new Pricing { Description = "Wedding (2 Hours)", Location = "Oklahoma City", Price = 775m },
            new Pricing { Description = "Corporate Event (3 Hours)", Location = "Oklahoma City", Price = 1100m }
        );

        // Seed Contacts
        context.Contacts.AddRange(
            new Contact
            {
                Name = "Emily Smith",
                Email = "emily@example.com",
                PhoneNumber = "123-456-7890",
                Message = "Interested in booking for a birthday party.",
                MemberID = 1,
                PricingID = 1
            },
            new Contact
            {
                Name = "Michael Johnson",
                Email = "michael@example.com",
                PhoneNumber = "987-654-3210",
                Message = "Do you have availability for June?",
                MemberID = 2,
                PricingID = 5
            }
        );

        context.SaveChanges();
    }
}
