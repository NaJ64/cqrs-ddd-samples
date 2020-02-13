using System;
using System.Collections.Generic;

namespace Bazaar.Core.Entities
{
    public class Order : Entity
    {
        public DateTime OrderDate { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}