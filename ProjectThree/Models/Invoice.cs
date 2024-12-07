using System.Data.SqlTypes;
using System.Xml.Serialization;

namespace ProjectThree.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public SqlMoney Price { get; set; }
        public int SessionMinutes { get; set; }
        public Employee Employee { get; set; }
        public Patient Patient { get; set; }
    }
}
