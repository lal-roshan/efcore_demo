using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductDAO.Models
{
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        //public string Brand { get; set; }

        //public  List<Order> Orders { get; set; } // Eager loading - Explicit

        public virtual List<Order> Orders { get; set; } // Lazy loading for navigation property :: Orders
    }
}
