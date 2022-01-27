using CoffeShopDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShopDemo.Concrete
{
    class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
