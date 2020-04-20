using System;
using System.ComponentModel.DataAnnotations;

namespace Growing.Shared.Models
{
    public class Tray
    {
        public Tray()
        {
            SowingDate = DateTime.Now;
        }
        public int TrayId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Department { get; set; } 
        [Required]
        public string City { get; set; }
        public DateTime SowingDate { get; set; }
    }
}
 