using System;

namespace CoffeShopDemo
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBird { get; set; }
        public String NationalityId { get; set; }

    }
}
