using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerceApp.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string Status { get; set; }
    }
}
