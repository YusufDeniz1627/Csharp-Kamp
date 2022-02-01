using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    class GameSaleManager : IGameSaleService
    {
        public void GameSale(Game game, Gamer gamer, Offer offer)
        {
            Console.WriteLine(
                " Oyunun Adı ==>"+game.Name+
                " Oyunun Fiyatı ==>"+game.Price+
                " Kampanya İsmi ==>"+offer.OfferName+
                " Oyunu Satın Alan Kişi ==>"+gamer.Name
                );
        }
    }
}
