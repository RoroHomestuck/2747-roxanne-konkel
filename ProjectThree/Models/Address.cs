using System.Collections.Generic;

namespace ProjectThree.Models
{
    public class Address
    {
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }

        public ICollection<Patient> Patients { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Insurance> Insurances { get; set;}
    }
}
