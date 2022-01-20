using System;

namespace classApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 1500;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "C++";
            kurs2.KursEgitmeni = "Kablosuz Kedi";
            kurs2.IzlenmeOrani = 1200;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Java";
            kurs3.KursEgitmeni = "Yazılım Bilimi";
            kurs3.IzlenmeOrani = 1300;

            //Console.WriteLine(kurs1.KursAdı +  " : " + kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                //  Console.WriteLine(kurs.KursAdı +" "+ kurs.KursEgitmeni +" "+kurs.IzlenmeOrani);
            }


            /* //------------TERNARY OPERATOR---------
             int hayvanlarAlemi = 15;
             String kosul = hayvanlarAlemi < 20 ? "Orta Seviye" : "Küçük Seviye";

             Console.WriteLine(kosul);
            */
            //---------SWİTCH-CASE YAPISI
            /* 

              Console.WriteLine("Hangi Aydasınız : "); String ay = Console.ReadLine();

              switch (ay)
              {
                  case "Ocak":
                      Console.WriteLine("1. aydasınız");
                      break;
                  case "Şubat":
                      Console.WriteLine("2. aydasınız");
                      break;
                  case "Mart":
                      Console.WriteLine("3. aydasınız");
                      break;
                  case "Nisan":
                      Console.WriteLine("4. aydasınız");
                      break;
                  case "Mayıs":
                      Console.WriteLine("5. aydasınız");
                      break;
                  case "Haziran":
                      Console.WriteLine("6. aydasınız");
                      break;
                  case "Temmuz":
                      Console.WriteLine("7. aydasınız");
                      break;
                  case "Agustos":
                      Console.WriteLine("8. aydasınız");
                      break;
                  case "Eylül":
                      Console.WriteLine("9. aydasınız");
                      break;
                  case "Ekim":
                      Console.WriteLine("10. aydasınız");
                      break;
                  case "Kasım":
                      Console.WriteLine("11. aydasınız");
                      break;
                  case "Aralık":
                      Console.WriteLine("12. aydasınız");
                      break;
                  default:
                      Console.WriteLine("Lütfen Ay Bilgisini Giriniz");
                      break;
              }
              Console.ReadKey();
              */

            /*WHİLE DONGUSU*/
            /*  int number = 20;
              while (number>=0)
              {
                  Console.WriteLine(number);
                  number--;
              }
              */


            Product product1 = new Product();
            product1.name = "Laptop";
            product1.price = 2000;

            Product product2 = new Product();
            product2.name = "Tablet";
            product2.price = 1000;

            Product product3 = new Product();
            product3.name = "Telefon";
            product3.price = 1500;

            Product[] product = new Product[] { product1, product2, product3 };
            Console.WriteLine("FOREACH DÖNGÜSÜ");
            foreach (var products in product)
            {
                Console.WriteLine(products.name + " fiyatı => " + products.price);
            }
            String[] urunler = new String[] { "Laptop", "Tablet", "Telefon" };
            Console.WriteLine("for Dongusu");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }
            Console.WriteLine("While Dongusu");
            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j]);
                j++;
            }
        }
        

            class Product
        {
            public String name { get; set; }
            public int price { get; set; }
    }












        }  
            


            class Kurs {
            public String KursAdı { get; set; }

            public String KursEgitmeni { get; set; }

            public int IzlenmeOrani { get; set; }
        }
        

        }




            
  

