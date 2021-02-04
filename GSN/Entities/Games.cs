using GSN.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Entities
{
    public class Games : IGames
    {
        public int GameId { get; set ; }
        public int CategoryId { get ; set ; }
        public string GameName { get ; set ; }
        public int UnitPrice { get ; set ; }
    }
}
