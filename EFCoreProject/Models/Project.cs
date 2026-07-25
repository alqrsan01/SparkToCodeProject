using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        public int DepartmentNumber { get; set; }
    }
}
