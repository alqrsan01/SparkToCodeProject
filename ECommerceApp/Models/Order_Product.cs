using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceApp.Models
{
    [PrimaryKey("ProductId", "OrderId")]
    public class Order_Product
    {
        public int quantity { get; set; }

        // appearin relation
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // appearin relation
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
