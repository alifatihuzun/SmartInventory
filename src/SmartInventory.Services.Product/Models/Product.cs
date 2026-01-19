using System;
using System.ComponentModel.DataAnnotations;

namespace SmartInventory.Services.Product.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastModifiedAt { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
        
        public string? Description { get; set; }

        public Guid SupplierId { get; set; }
    }
}
