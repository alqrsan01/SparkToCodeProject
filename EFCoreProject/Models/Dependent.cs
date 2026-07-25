using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreProject.Models
{
    public class Dependent
    {
        [Key]
        public int DependentId { get; set; }
        public int EmployeeSsn { get; set; }
        public string DependentName { get; set; }
        public char Sex { get; set; }
        public string BirthDate { get; set; }
        public string Relationship { get; set; }
    }
}
