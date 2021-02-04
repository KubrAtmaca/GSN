using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public interface ICampaignManager
    {
        void Add(Games games,Campaigns campaigns);
        void Update(Games games,Campaigns campaigns);
        void Delete(Games games,Campaigns campaigns);
    }
}
