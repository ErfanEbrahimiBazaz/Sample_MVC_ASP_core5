using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string CEOName { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        public string Address { get; set; }

    }
}
