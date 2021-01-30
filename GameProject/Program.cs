using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            { 
                Id = 1, BirthYear = 1998, 
                FirstName = "Salih", 
                LastName = "Kamaş", 
                IdentityNumber = 11111111111 
            });
            CampaignManager campaign = new CampaignManager();
            campaign.Add(new Campaign { Id = 1, CampaignName = "Halloween Campaign", Discount = 75 });
            SalesManager sales = new SalesManager();
            sales.Sell(new Gamer {
                Id = 1,
                BirthYear = 1998,
                FirstName = "Salih",
                LastName = "Kamaş",
                IdentityNumber = 11111111111
            }, new Sales { Id = 1, Price = 100, Quantity = 2 },new Campaign {
                Id = 1,
                CampaignName = "Halloween Campaign",
                Discount = 75
            });
        }
    }
}
