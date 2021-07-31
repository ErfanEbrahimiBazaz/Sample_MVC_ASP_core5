using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Organization { get; set; }
        public string ContactPerson{ get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
    }
}
