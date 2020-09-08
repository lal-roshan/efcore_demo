using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAO.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
