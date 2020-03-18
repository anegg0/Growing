﻿using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared.Models
{
    public class Tray
    {
        public int TrayId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string City { get; set; }
        public SowingDate CreatedTime { get; set; }
    }
}
