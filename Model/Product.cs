using System.ComponentModel.DataAnnotations;

namespace StoreSharp
{
    public partial class Product
    {
        public long ProductId { get; set; }
        
        [Required]
        public string Name { get; set; } = null!;
        
        [Required]
        public Category Category { get; set; } = null!;
        
        public double unitPrice { get; set; } = 0.0;
        public int quantity { get; set; } = 0;

        public string? ExtraData { get; set; } = "";
        
        [Required]
        public DateTime creationDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime updateDate { get; set; } = DateTime.Now;
    }
}
