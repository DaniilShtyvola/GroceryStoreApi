namespace GroceryStore
{
    public class Category
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public uint? ParentCategoryId { get; set; }
    }
}
