using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Xml.Serialization;

namespace ProjectThree.Models
{
    public class Invoice
    {
        [Key]
        [Required]
        public int InvoiceID { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int SessionMinutes { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public int PatientID { get; set; }


        public Employee Employee { get; set; }
        public Patient Patient { get; set; }
    }
}
