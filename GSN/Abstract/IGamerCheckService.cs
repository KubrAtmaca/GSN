using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
