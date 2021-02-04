using System;
using System.Collections.Generic;
using System.Text;
using GSN.Abstract;
using GSN.Entities;
using MernisServiceReference;

namespace GSN.Adapters
{
    public class MernisServiceAdapter:IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrula(gamer.NationalityId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
        }
    }
}
