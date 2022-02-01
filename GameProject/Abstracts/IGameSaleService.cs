using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
    public interface IGameSaleService
    {
        void GameSale(Game game,Gamer gamer,Offer offer);
    }
}
