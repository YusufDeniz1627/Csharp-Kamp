using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "elma";
            product1.Id = 1;
            product1.Price = 17;

            Product product2 = new Product();
            product2.Name = "Erik";
            product2.Id = 2;
            product2.Price = 13;

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("-------Metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut","Yeşil",15,9);
        }
    }
}
