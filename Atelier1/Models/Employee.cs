﻿using System.ComponentModel.DataAnnotations;
namespace Atelier1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required,StringLength (10,ErrorMessage ="taille max 10 characters")]
        public string Name { get; set; }
        [Required]
        public string Departement { get; set; }
        [Range (200,5000)]

        public int Salary { get; set; }
    }
}
