using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerceApp.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string Status { get; set; }

        // contains relation
        public List<Order_Product> OrderProducts { get; set; }

        // reviewsby relation
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
