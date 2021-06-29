﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Models
{
    public class ProblemPost
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int ConsumerId { get; set; }
        [Required]
        public string Image { get; set; }
        public virtual Consumer Consumer { get; set; }
    }
}