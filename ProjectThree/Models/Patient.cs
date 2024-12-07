using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectThree.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public PhoneAttribute PhoneNumber { get; set; }
        public Employee Therapist { get; set; }
        public Insurance Insurance { get; set; }
        public Address Address { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
