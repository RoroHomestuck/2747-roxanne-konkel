using System.Collections;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ProjectThree.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public PhoneAttribute PhoneNumber { get; set; }
        public EmailAddressAttribute EmailAddress { get; set; }
        public Address Address { get; set; }

        public ICollection<Patient> Patients { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

    }
}
