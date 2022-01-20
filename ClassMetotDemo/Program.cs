using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Yusuf";
            customer1.LastName = "Deniz";
            customer1.Id = 1;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.List(customer1);
        }
    }
}
