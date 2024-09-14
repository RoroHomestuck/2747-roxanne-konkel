using Bookstore_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_App.DataAccess
{
    internal static class ProductDatabase
    {

        private static string fileName = "Product.txt";
        private static string path = Environment.CurrentDirectory;
        private static string seperator = "|";


        public static List<Product> GetProducts()
        {
            var products = new List<Product>();

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

                if (parts.Length == 3)
                {
                    products.Add(new Product()
                    {
                        SKU = parts[0],
                        Description = parts[1],
                        Price = Convert.ToDecimal(parts[2])
                    });
                }
            }

            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            using StreamWriter sw = new StreamWriter(new FileStream(Path.Combine(path, fileName), FileMode.Create, FileAccess.Write));


                foreach (Product product in products)
                {
                    sw.Write(product.SKU + seperator);
                    sw.Write(product.Description + seperator);
                    sw.WriteLine(product.Price);
                }
            
        }
    }
}
