using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstracts
{
    interface IGameSaleService
    {
        void Sale(Gamer gamer,Campaign campaign,Game game);
    }
}
