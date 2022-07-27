using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkGlutton.Mvc.Data.Models
{
    public class Link
    {
        [MaxLength(128)]
        public string Full { get; set; }

        [Key]
        [MaxLength(32)]
        public string Short { get; set; }
        public DateTime CreationDate { get; set; }
        [MaxLength(64)]
        public string CreatedBy { get; set; }

    }
}
