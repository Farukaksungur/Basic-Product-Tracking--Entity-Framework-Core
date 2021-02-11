using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework_.net_core.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name   { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
