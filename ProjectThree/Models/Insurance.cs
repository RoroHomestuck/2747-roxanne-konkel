using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectThree.Models
{
    public class Insurance
    {
        [Key]
        [Required]
        public int InsuranceID { get; set; }
        [Required]
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public bool isAccepted { get; set; }
        [Required]
        public int AddressID { get; set; }


        public Address Address { get; set; }
    }
}
