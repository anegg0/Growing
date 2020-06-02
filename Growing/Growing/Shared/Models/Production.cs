using System;
using System.ComponentModel.DataAnnotations;

namespace Growing.Shared.Models
{
    public class Production
    {
        public Production()
        {
            SowingDate = DateTime.Now;
        }
        public int ProductionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TrayTypeId { get; set; }
        [Required]
        public string Department { get; set; } 
        [Required]
        public string City { get; set; }
        public DateTime SowingDate { get; set; }
    }
}
 
