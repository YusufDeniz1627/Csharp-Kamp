using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concretes
{
    class SaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Campaign campaign,Game game)
        {
          


            Console.WriteLine(gamer.Name+" İsimli Kullanıcıya "+campaign.Name+" Kampanyası ile "+
                game.Name+" Adındaki Oyun "+game.Price+" TL'den Satılmıştır");
        }
    }
}
