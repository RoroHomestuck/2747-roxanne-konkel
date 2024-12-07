using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectThree.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int AddressID { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string County { get; set; }
        [Required]
        public string State { get; set; }
    }
}
