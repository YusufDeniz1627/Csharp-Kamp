using System;
using System.Collections.Generic;
using System.Text;
using CoffeShopDemo.Abstract;
namespace CoffeShopDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _checkService;

        public StarbucksCustomerManager(IPersonCheckService checkService)
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
