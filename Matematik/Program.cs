using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem islem = new DortIslem();
            Console.WriteLine("-------Toplama");
            islem.Topla(1,5);
            Console.WriteLine("-------Çıkarma");
            islem.Çıkar(6, 5);
            Console.WriteLine("-------Çarpma");
            islem.Çarp(2, 5);
            Console.WriteLine("-------Bölme");
            islem.Bölme(10, 2);
        }
    }
}
