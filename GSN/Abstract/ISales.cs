using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public interface ISales
    {
        public int SalesId { get; set; }
        public string GameId { get; set; }
        public string CampaignId { get; set; }
        public string SalesmanName { get; set; }
    }
}
