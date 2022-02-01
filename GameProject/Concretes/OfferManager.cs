using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("Yeni Kampanya Eklendi");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Yeni Kampanya Silindi");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Yeni Kampanya Güncellendi");
        }
    }
}
