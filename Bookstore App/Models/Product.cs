using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_App.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; } = "";
        public string Description { get; set; } = "";
        public Decimal Price { get; set; }

        public override string ToString()
        {
            return $"{SKU} {Description} ({Price.ToString("c")})";
        }
    }
}
