using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShopDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
