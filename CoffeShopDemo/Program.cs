using CoffeShopDemo.Abstract;
using CoffeShopDemo.Adapters;
using CoffeShopDemo.Concrete;
using System;

namespace CoffeShopDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customer = new NeroCustomerManager(new MernisServiceAdapter());

            Customer customer1 = new Customer() { Id=1,Name="",LastName="",NationalityId= "13456789", DateOfBird=new DateTime(2006,11,7)};

            //customer.Save(new Customer {DateOfBird=new DateTime(2006,11,07),Name="Yusuf",LastName="Deniz",NationalityId="13456789",Id=1 });
            customer.Save(customer1);


        }
    }
}
