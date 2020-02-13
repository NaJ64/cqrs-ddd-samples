using System;
using System.Collections.Generic;

namespace Bazaar.Core.Entities
{
    public class Cart : Entity
    {
        public DateTime CreatedOn { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public List<CartDetail> CartDetails { get; set; }
    }
}