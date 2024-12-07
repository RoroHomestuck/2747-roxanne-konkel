using ProjectThree.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectThree.Data
{
    public class TherapyContext : DbContext
    {
        public TherapyContext(DbContextOptions<TherapyContext> options) : base(options)
        {

        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Patient> Patients { get; set; }

    }
}
