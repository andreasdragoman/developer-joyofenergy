﻿using System.ComponentModel.DataAnnotations;

namespace JOIEnergy.Database.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
