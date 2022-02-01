using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public String OfferName { get; set; }
        public DateTime StartOffer { get; set; }
        public DateTime EndOffer { get; set; }
    }
}
