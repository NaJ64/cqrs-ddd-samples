namespace Bazaar.Core.Entities
{
    public class Product : Entity
    {
        public string SKU { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}