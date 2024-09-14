using Bookstore_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_App.DataAccess
{
    internal class InvoicesDatabase
    {
        private static string fileName = "Invoices.txt";
        private static string path = Environment.CurrentDirectory;
        private static string seperator = "|";

        public static List<Invoice> GetInvoices()
        {
            var invoices = new List<Invoice>();
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
                    invoices.Add(new Invoice()
                    {
                        Id = Convert.ToInt32(parts[0]),
                        CustomerId = Convert.ToInt32(parts[1]),
                        InvoiceDate = Convert.ToDateTime(parts[2]),
                        InvoiceTotal = Convert.ToInt32(parts[3]),
                    });
                }
            }

            if (invoices.Count == 0)
            {
                invoices.Add(new Invoice() {Id = 0, CustomerId = 0, InvoiceDate = DateTime.Now, InvoiceTotal = 10});
                invoices.Add(new Invoice() {Id = 1, CustomerId = 0, InvoiceDate = DateTime.Now, InvoiceTotal = 100});
                invoices.Add(new Invoice() {Id = 2, CustomerId = 9, InvoiceDate = DateTime.Now, InvoiceTotal = 2});
                invoices.Add(new Invoice() {Id = 3, CustomerId = 9, InvoiceDate = DateTime.Now, InvoiceTotal = 23});
                invoices.Add(new Invoice() {Id = 4, CustomerId = 2, InvoiceDate = DateTime.Now, InvoiceTotal = 15});
            }
            return invoices;
        }
    }
}
