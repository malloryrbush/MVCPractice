using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPractice2.Models
{
    public class Customers
    {
        [Key]
        public string Name { get; set; }
        public string Teleophone { get; set; }
        public string Address { get; set; }
    }
}