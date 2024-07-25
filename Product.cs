namespace GroceryStore
{
    public class Product
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public uint CategoryId { get; set; }
        public double Price { get; set; }
        public uint Amount { get; set; }
        public uint ManufacturerId { get; set; }
        public uint ProviderId { get; set; }
    }
}
