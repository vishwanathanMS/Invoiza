using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Contact { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        public decimal Dues { get; set; }
    }
}
