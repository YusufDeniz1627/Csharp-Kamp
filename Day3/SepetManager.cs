using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class SepetManager
    {
        //naming - convention
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi. ==>" + product.Name);
        }

        public void Ekle2(String productName,String productDetail,int productPrice,int productStockAmounth)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi. ==>" + productName);
        }
    }
}
