using System;
using System.ComponentModel.DataAnnotations;

namespace DonationMonitor.Models
{
    public class Donation
    {
        [Key]                          // Marks this as the primary key
        public int Id { get; set; }

        [Required, MaxLength(100)]     // Enforces a non-null donor name, max 100 chars
        public string DonorName { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
