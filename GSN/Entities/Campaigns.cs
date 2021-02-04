using GSN.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Entities
{
    public class Campaigns : ICampaign
    {
        public int CampaignId { get ; set ; }
        public int GameId { get ; set ; }
        public double Discount { get ; set ; }
        public DateTime CampaignStartTime { get; set; }
        public DateTime CampaignFinishTime { get ; set; }
        public string CampaignName { get ; set; }
    }
}
