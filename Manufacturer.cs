namespace GroceryStore
{
    public class Manufacturer
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Address { get; set; }
        public required string Country { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
    }
}
