using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public interface IGames
    {
        int GameId { get; set; }
        int CategoryId { get; set; }
        string GameName { get; set; }
        int UnitPrice { get; set; }


    }
}
