using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myfirstproject.Models
{
    public class Vehiclecategory
    {
        public int id { get; set; }
        public List<categoryname> categorynames { get; set; }
    }
}