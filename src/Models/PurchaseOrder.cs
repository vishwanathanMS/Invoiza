using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderId { get; set; }

        public int SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; } = null!;

        [Required]
        public DateTime OrderDate { get; set; }

        [Required, MaxLength(20)]
        public string Status { get; set; } = "Pending";

        public decimal Total { get; set; }
    }
}
