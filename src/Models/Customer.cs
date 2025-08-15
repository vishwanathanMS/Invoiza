using System.ComponentModel.DataAnnotations;

namespace MauiApp1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(15)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        [MaxLength(15)]
        public string? GSTIN { get; set; }

        [Required, MaxLength(20)]
        public string CustomerType { get; set; } = "Unregistered";

        public int LoyaltyPoints { get; set; }
    }
}
