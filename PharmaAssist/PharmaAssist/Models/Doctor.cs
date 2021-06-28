﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmaAssist.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
     
        public int? LoginId { get; set; }
        public int? SpecialistId { get; set; }
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
        public int Fee { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public virtual Login Login { get; set; }
        public virtual Specialist Specialist { get; set; }


        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }
}