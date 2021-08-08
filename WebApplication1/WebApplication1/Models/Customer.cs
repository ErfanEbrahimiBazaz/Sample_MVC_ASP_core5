using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RefrenceLib;


namespace WebApplication1.Models
{
    public class Customer
    {
        [Key]
        [Display(Name = nameof(Titles.CustomerId), ResourceType = typeof(Titles))]
        public int CustomerId { get; set; }
        [Required(ErrorMessageResourceName = nameof(ErrorMessages.Required), ErrorMessageResourceType = typeof(ErrorMessages))]
        [RegularExpression(@"[a-zA-Z]+[\x20]*[a-zA-Z]*", ErrorMessageResourceName =nameof(ErrorMessages.RegExName), ErrorMessageResourceType =typeof(ErrorMessages))]
        [Display(Name = nameof(Titles.Organization), ResourceType = typeof(Titles))]
        public string Organization { get; set; }
        [Display(Name = nameof(Titles.ContactPerson), ResourceType = typeof(Titles))]
        public string ContactPerson { get; set; }
        [Display(Name = nameof(Titles.Address), ResourceType = typeof(Titles))]
        public string Address { get; set; }
        [Display(Name = nameof(Titles.Nationality), ResourceType = typeof(Titles))]
        public string Nationality { get; set; }
        
    }
}
