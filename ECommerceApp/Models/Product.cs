using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // has relation
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // appearin relation
        public List<Order_Product> Order_Products { get; set; }
    }
}
