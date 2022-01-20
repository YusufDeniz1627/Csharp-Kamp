using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            String ad = "Yusuf";
            int yas = 15;

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

            Console.WriteLine(kurs1.KursAdı + " " + kurs1.KursEgitmeni + " " + kurs1.IzlenmeOrani);

            class Kurs
        {
            public String KursAdı { get; set; }

            public String KursEgitmeni { get; set; }

            public int IzlenmeOrani { get; set; }
        }
    }
}
    

