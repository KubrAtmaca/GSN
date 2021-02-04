using GSN.Abstract;
using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Games games, Campaigns campaigns)
        {
            Console.WriteLine(campaigns.CampaignName+" added at. ");
        }

        public void Delete(Games games, Campaigns campaigns)
        {
            Console.WriteLine(campaigns.CampaignName + " deleted at. ");
        }

        public void Update(Games games, Campaigns campaigns)
        {
            Console.WriteLine(campaigns.CampaignName + " updated at .");
        }
    }
}
