using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concretes
{
    class CampaignManager : ICampaingService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +" İsimli Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " İsimli Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " İsimli Kampanya Güncellendi");
        }
    }
}
