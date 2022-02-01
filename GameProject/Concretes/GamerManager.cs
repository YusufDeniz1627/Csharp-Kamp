using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    public class GamerManager : IGameSaleService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
