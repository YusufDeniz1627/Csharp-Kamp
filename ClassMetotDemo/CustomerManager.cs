using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " İsimli Müşteri Eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " İsimli Müşteri Silindi");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.Name + " İsimli Müşteri Listelendi");
        }


    }
}
