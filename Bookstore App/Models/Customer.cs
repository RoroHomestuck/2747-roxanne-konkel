using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_App.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FName { get; set; } = "";
        public string LName { get; set; } = "";
        public string Email { get; set; } = "";

        public override string ToString()
        {
            return $"{FName} {LName}, {Email}";
        }
    }
}
