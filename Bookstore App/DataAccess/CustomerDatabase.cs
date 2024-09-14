using Bookstore_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_App.DataAccess
{
    internal static class CustomerDatabase
    {

        private static string fileName = "Customer.txt";
        private static string path = Environment.CurrentDirectory;
        private static string seperator = "|";
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            

            using StreamReader reader = new(Path.Combine(path, fileName));

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(seperator);

                if (parts.Length == 3)
                {
                    customers.Add(new Customer()
                    {
                        FName = parts[0],
                        LName = parts[1],
                        Email = parts[2]
                    });
                }
            }

            return customers;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            using StreamWriter sw = new StreamWriter(Path.Combine(path, fileName));

            foreach (Customer customer in customers)
            {
                sw.Write(customer.FName + seperator);
                sw.Write(customer.LName + seperator);
                sw.WriteLine(customer.Email);
            }

        }
    }
}
