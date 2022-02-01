
using GameProject.Abstracts;
using GameProject.Adapters;
using GameProject.Concretes;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer {Id=1,Name="Yusuf",LastName="Deniz",TcNo="12345679",DateOfBird=new DateTime(2006,1,7) };
            Game game1 = new Game { Id = 1, Name = "Days Gone", Price="220" };
            Offer offer = new Offer {Id=1,OfferName="Kış Ayı Kampanyası ",StartOffer=new DateTime(2022,1,1),EndOffer=new DateTime(2022,2,10) };
            //GameManager gameManager = new GameManager();
            //gameManager.Update(game1);

            CheckService service = new CheckService();
            service.Check(gamer);
        }
    }
}
