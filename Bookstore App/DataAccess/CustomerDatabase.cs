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

            using StreamReader reader = new(
                new FileStream(
                    Path.Combine(path, fileName),
                    FileMode.OpenOrCreate,
                    FileAccess.Read)
                );

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(seperator);

                if (parts.Length == 4)
                {
                    customers.Add(new Customer()
                    {
                        Id = Convert.ToInt32(parts[0]),
                        FName = parts[1],
                        LName = parts[2],
                        Email = parts[3]
                    });
                }
            }

            return customers;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            using StreamWriter sw = new StreamWriter(new FileStream(Path.Combine(path, fileName), FileMode.Create, FileAccess.Write));

            foreach (Customer customer in customers)
                {
                    sw.Write(customer.Id + seperator);
                    sw.Write(customer.FName + seperator);
                    sw.Write(customer.LName + seperator);
                    sw.WriteLine(customer.Email);
                }
            

        }
    }
}
