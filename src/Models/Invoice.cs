using Google.Apis.Drive.v3.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MudBlazor.Icons;

namespace MauiApp1.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required, MaxLength(20)]
        public string InvoiceNumber { get; set; } = string.Empty;

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        public decimal Subtotal { get; set; }

        public decimal CGST { get; set; }

        public decimal SGST { get; set; }

        public decimal IGST { get; set; }

        public decimal Discount { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required, MaxLength(20)]
        public string PaymentStatus { get; set; } = "Pending";

        public int CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User User { get; set; } = null!;
    }
}
