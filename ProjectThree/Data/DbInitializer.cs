using ProjectThree.Models;
using System;
using System.Linq;

namespace ProjectThree.Data
{
    public class DbInitializer
    {
        public static void Initialize(TherapyContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            var employees = new Employee[]
            {
                new Employee {}
            };

            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

            var 

        }
    }
}
