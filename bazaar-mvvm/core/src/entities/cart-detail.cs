namespace Bazaar.Core.Entities
{
    public class CartDetail : Entity
    {
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }

        public int ProductId { get; set; }
        public int CartId { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
    }
}