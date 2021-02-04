using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public  interface ISalesManager
    {
        void Sale(Gamer gamer, Games games, Campaigns campaigns);
        void Return(Gamer gamer, Games games, Campaigns campaigns);
    }

    
}
