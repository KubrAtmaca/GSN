using GSN.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Concrete
{
    public class Sales : ISales
    {
        public int SalesId { get ; set ; }
        public string GameId { get ; set ; }
        public string CampaignId { get ; set ; }
        public string SalesmanName { get ; set ; }
    }
}
