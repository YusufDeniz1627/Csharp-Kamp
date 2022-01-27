using CoffeShopDemo.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShopDemo.Adapters
{
    class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,customer.Name.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBird.Year);
        }
    }
}
