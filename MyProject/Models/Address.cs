﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    [Table("project")]
    public class Address
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? Gender { get; set; }

    }
}
