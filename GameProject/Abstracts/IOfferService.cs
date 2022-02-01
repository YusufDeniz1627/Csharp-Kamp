using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstracts
{
    interface IOfferService
    {
        void Add(Offer offer);
        void Delete(Offer offer);
        void Update(Offer offer);


    }
}
