using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kmet_API_Business.Models
{
    public class ItemOrder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public User Seller { get; set; }
        [Required]
        public User Buyer { get; set; }
        [Required]
        public Item Item { get; set; }
        [Required]
        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime OrderSubmited { get; set; }
        public DateTime OrderCompleted { get; set; }
    }
}
