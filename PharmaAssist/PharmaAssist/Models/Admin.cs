﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace PharmaAssist.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? LoginId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public virtual Login Login { get; set; }
    }
}