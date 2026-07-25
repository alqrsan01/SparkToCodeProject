using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreProject.Models
{
    public class WorksOn
    {
        [Key]
        public int WorksOnId { get; set; }
        public int EmployeeSsn { get; set; }
        public int ProjectNumber { get; set; }
        public double Hours { get; set; }
    }
}
