using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String kategoriEtiketi = "kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.5;
            bool girisYapıldımı = true;
            double dolarDun=1.75;
            double dolarBugun = 1.85;


            if (dolarDun>dolarBugun) 
            {
                Console.WriteLine("Düşüş Oku.");
            }
            else if (dolarDun == dolarBugun)
            {
                Console.WriteLine("Degişmemiştir Oku");
            }
            else
            {
                Console.WriteLine("YÜkseliş Oku")
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
