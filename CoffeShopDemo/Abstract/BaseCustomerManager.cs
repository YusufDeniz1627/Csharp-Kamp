using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShopDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved To db ==> "+customer.Name);
        }
    }
}
