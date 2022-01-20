using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] kurslar = new String[] {"Yazılım başlangıç kampı","Yazılım Orta Seviye Kampı",
                "Yazılım Uzman Seviye Kampı","python kursu","Java kursu","C+" };

            for (int i = 0; i <kurslar.Length; i++)
             {
                   Console.WriteLine(kurslar[i]);
             }

            Console.WriteLine("--------------------For Bitti!<=Foreach Döngüsü Başladı------------------");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("-----------------");

            









            Console.WriteLine("Sayfa sonu -- Footer");
        }
    }
}
