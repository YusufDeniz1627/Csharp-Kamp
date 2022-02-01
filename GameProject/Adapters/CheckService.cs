using GameProject.Abstracts;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    class CheckService : ICheckIfRealPerson
    {
        public bool Check(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(gamer.TcNo, gamer.Name.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBird.Year);
        }
    }
}
