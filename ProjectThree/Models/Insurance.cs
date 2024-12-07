using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectThree.Models
{
    public class Insurance
    {
        public int ID { get; set; }
        public string Company { get; set; }
        public PhoneAttribute PhoneNumber { get; set; }
        public bool isAccepted { get; set; }
        public Address Address { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
