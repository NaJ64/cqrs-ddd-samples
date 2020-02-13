using System;
using System.Collections.Generic;

namespace Bazaar.ApplicationServices.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetailViewModel> OrderDetails { get; set; }
        public int BuyerId { get; set; }
    }
    
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
    }
}