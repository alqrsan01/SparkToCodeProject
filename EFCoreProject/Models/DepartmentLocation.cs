using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreProject.Models
{
    public class DepartmentLocation
    {
        [Key]
        public int DepartmentLocationId { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentLocationName { get; set; }
    }
}
