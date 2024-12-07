using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectThree.Models
{
    public class Patient
    {
        [Key]
        [Required]
        public int PatientID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        [ForeignKey("EmployeeID")]
        public int TherapistID { get; set; }
        [ForeignKey("InsuranceID")]
        public int InsuranceID { get; set; }
        [Required]
        [ForeignKey("AddressID")]
        public int AddressID { get; set; }


    }
}
