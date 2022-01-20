using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayı1,int sayı2)
        {
            int Toplam=sayı1 + sayı2;
            Console.WriteLine("İslem Sonucu ==>"+Toplam);
        }

        public void Çıkar(int sayı1, int sayı2)
        {
            int Toplam = sayı1 - sayı2;
            Console.WriteLine(Toplam);
        }

        public void Çarp(int sayı1, int sayı2)
        {
            int Toplam = sayı1 * sayı2;
            Console.WriteLine(Toplam);
        }

        public void Bölme(int sayı1, int sayı2)
        {
            int Toplam = sayı1 / sayı2;
            Console.WriteLine(Toplam);
        }
    }
}
