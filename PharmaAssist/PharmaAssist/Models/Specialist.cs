using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist.Models
{
    public class Specialist
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Doctor> Doctor { get; set; }
    }
}