using System.Collections;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectThree.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        [ForeignKey("AddressID")]
        public int AddressID { get; set; }

        
    }
}
