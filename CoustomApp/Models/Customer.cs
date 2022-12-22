using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoustomApp.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public long Phone { get; set; }

        public string Address { get; set; }
    }
}
