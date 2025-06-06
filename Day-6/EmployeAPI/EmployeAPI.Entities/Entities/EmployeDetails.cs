﻿using System.ComponentModel.DataAnnotations;

namespace EmployeAPI.Entities.Entities
{
    public class EmployeDetails
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
