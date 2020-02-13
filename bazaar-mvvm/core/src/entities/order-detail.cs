namespace Bazaar.Core.Entities
{
    public class OrderDetail : Entity
    {
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}