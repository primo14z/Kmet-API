using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kmet_API_Business.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string Picture { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public int Frequency { get; set; }
        public bool IsBasket { get; set; }
    }
}
