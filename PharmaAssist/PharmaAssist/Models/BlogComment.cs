using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace PharmaAssist.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int LoginId { get; set; }
        public virtual Login Login { get; set; }


    }
}