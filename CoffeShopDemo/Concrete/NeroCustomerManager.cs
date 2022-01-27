using CoffeShopDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShopDemo.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        private IPersonCheckService _checkService;

        public NeroCustomerManager(IPersonCheckService checkService)
        {
            _checkService = checkService;
        }

        public override void Save(Customer customer)
        {
            if (_checkService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person ");
            }

        }
    }
}
