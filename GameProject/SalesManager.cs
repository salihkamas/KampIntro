using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Sales sales,Campaign campaign)
        {
            double dp = sales.Price - (sales.Price / 100 * campaign.Discount);
            Console.WriteLine("The purchase was made successfully : {0} {1} \nPrice : {2} \nDiscounted Price : {3} \nCampaign Name : {4}",gamer.FirstName,gamer.LastName,sales.Price,dp,campaign.CampaignName);
        }

    }
}
