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
        public User Seller { get; set; }
        public User Buyer { get; set; }
        public Item Item { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime OrderSubmited { get; set; }
        public DateTime OrderCompleted { get; set; }
    }
}
