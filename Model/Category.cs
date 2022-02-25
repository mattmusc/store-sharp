namespace StoreSharp
{
    public partial class Category
    {
        public long CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public Category? Parent { get; set; }
    }
}
