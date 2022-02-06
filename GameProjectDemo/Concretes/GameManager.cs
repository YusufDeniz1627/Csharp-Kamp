using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concretes
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name+" Oyunu Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Oyunu Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Oyunu Güncellendi");
        }
    }
}
