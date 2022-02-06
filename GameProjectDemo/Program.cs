using GameProjectDemo.Concretes;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaign campaign1 = new Campaign() {Id=1,Name="Kış Sezonu " };
            CampaignManager managerCampaign = new CampaignManager();
            managerCampaign.Add(campaign1);

            GamerManager manager = new GamerManager(new UserValidateManager());
            Gamer gamer1 = new Gamer() { Id = 1, Name = "Yusuf", LastName = "Ak", BirthYear = 2006, NationalityNumber = 123 };
            manager.Add(gamer1);

            Game game = new Game() {Id=1,Name="Red Dead Redeption 2",Price="299" };

            SaleManager sale = new SaleManager();
            sale.Sale(gamer1,campaign1,game);

           
        }
    }
}
