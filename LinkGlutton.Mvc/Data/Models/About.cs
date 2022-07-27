using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkGlutton.Mvc.Data.Models
{
    public class About
    {
        [MaxLength(128)]
        public string Author { get; set; }
        public int TotalLinks { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }
    }
}
