using System;
using System.Collections.Generic;

namespace Bazaar.Core.Entities
{
    public class Buyer : Entity
    {
        public string Name { get; set; }
        public int BuyerScore { get; set; }
        public List<Order> Orders { get; set; }
    }
}