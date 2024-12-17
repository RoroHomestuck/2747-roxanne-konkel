using Microsoft.AspNetCore.Mvc.Formatters;
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

            if (context.Patients.Any())
            {
                return;
            }

            // ------------------------------------------------------------------------

            var employees = new Employee[]
            {
                new Employee {FirstName="Jessica",MiddleName="Kleinstein",LastName="Riddlestomp",PhoneNumber="502-232-5232",EmailAddress="risica@wvtherapy.com",AddressID=0}
            };

            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();



            // ------------------------------------------------------------------------

            var patients = new Patient[]
            {
                new Patient {FirstName="Ince",MiddleName="",LastName="Microsoft",PhoneNumber="123-2300-002",TherapistID=0,InsuranceID=0,AddressID=1}
            };
            foreach (Patient p in patients)
            {
                context.Patients.Add(p);
            }
            context.SaveChanges();


            // ------------------------------------------------------------------------

            var addresses = new Address[]
            {
                new Address {HouseNumber=23,Street="Wilkinson", City="Westview",County="Direga",State="Nevada"},
                new Address {HouseNumber=12542, Street="County Road 72",City="Outerview",County="Direga",State="Nevada"},
                new Address {HouseNumber=13, Street="Main",City="Eastview",County="Direga",State="Nevada"}
            };
            foreach (Address a in addresses)
            {
                context.Addresses.Add(a);
            }
            context.SaveChanges();

            // ------------------------------------------------------------------------

            var insurance = new Insurance[]
            {
                new Insurance {Company="ScamCare Inc.",PhoneNumber="180-202-1222", isAccepted=true, AddressID=2}
            };
            foreach (Insurance i in insurance)
            {
                context.Insurance.Add(i);
            }
            context.SaveChanges();

            // ------------------------------------------------------------------------

            var invoices = new Invoice[]
            {
                new Invoice {PatientID=0,EmployeeID=0,Price=10,SessionMinutes=2}
            };
            foreach (Invoice i in invoices)
            {
                context.Invoices.Add(i);
            }
            context.SaveChanges();
        }
    }
}
