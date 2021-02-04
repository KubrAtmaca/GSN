using GSN.Abstract;
using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Concrete
{
    public class SalesManager : ISalesManager
    {
        public void Return(Gamer gamer, Games games, Campaigns campaigns)
        {
            Console.WriteLine("Oyun iade edildi.",games.GameId+" "+gamer.GamerId+" "+campaigns.CampaignId);
        }

        public void Sale(Gamer gamer, Games games, Campaigns campaigns)
        {
            Console.WriteLine("Oyun satıldı.", games.GameId + " " + gamer.GamerId + " " + campaigns.CampaignId);
        }
    }
}
