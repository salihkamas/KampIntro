using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} Added!", campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} Deleted!", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} Updated!", campaign.CampaignName);
        }
    }
}
