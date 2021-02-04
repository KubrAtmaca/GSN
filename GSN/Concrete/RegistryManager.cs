using GSN.Abstract;
using GSN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSN.Concrete
{
    public class RegistryManager :BaseRegisteryService
    {
        private IGamerCheckService _gamerCheckService;
       

        public RegistryManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public override void Registry(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Registry(gamer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
    }
}
