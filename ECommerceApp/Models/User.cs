using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerceApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        // has relation
        public List<Order> Orders { get; set; }
    }
}
