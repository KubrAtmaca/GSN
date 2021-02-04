using GSN.Abstract;
using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            return true;
        }
    }
}
