using System;
using System.ComponentModel.DataAnnotations;

namespace Growing.Shared.Models
{
    public class TrayType
    {
        public int TrayTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Handle { get; set; }
        [Required]
        public string Length { get; set; }
        [Required]
        public string Width { get; set; }
        [Required]
        public string Height { get; set; }
        public string Notes { get; set; }
    }
}
 