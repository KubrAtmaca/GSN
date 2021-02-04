using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public interface ICampaign
    {
        int CampaignId { get; set; }
        int GameId { get; set; }

        string CampaignName { get; set; }
        double Discount { get; set; }
        DateTime CampaignStartTime { get; set; }
        DateTime CampaignFinishTime { get; set; }
    }
}
