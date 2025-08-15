using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, MaxLength(50)]
        public string SKU { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(10)]
        public string? HSNCode { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        public int LowStockThreshold { get; set; }

        [MaxLength(50)]
        public string? BatchNumber { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [MaxLength(20)]
        public string? Unit { get; set; }
    }
}
