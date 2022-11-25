using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryModel.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime BirthDate { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public int CityID { get; set; }
        public City? City { get; set; }

    }
}
