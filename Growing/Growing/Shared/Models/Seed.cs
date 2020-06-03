using System;
using System.ComponentModel.DataAnnotations;

namespace Growing.Shared.Models
{
    public class Seed
    {
        public int SeedId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Handle { get; set; }
        [Required]
        public int SeedLifetime { get; set; }
        [Required]
        public int SeedingRate { get; set; }
        [Required]
        public string CurrentDTM { get; set; } 
        public string DTM1 { get; set; }
        public string DTM2 { get; set; }
        public string DTM3 { get; set; }
        public string DTM4 { get; set; }
        [Required]
        public int SeasonId { get; set; }
    }
}
 
