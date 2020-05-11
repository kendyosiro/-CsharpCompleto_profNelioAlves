using Secao16_ExpressoesLambda_Delegates_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Secao16_ExpressoesLambda_Delegates_LINQ
{

    //Utilizando LINQ para realizar diversas operações sobre uma coleção

    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer", 1100.00, c2),
                new Product(2, "Hammer", 90.00, c1),
                new Product(3, "TV", 1700.00, c3),
                new Product(4, "Notebook", 1300.00, c2),
                new Product(5, "Saw", 80.00, c1),
                new Product(6, "Tablet", 700.00, c2),
                new Product(7, "Camera", 700.00, c3),
                new Product(8, "Printer", 350.00, c3),
                new Product(9, "MacBook", 1800.00, c2),
                new Product(10, "Sound Bar", 700.00, c3),
                new Product(11, "Level", 70.00, c1)
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODCTUS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("PRODUCTS STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("PRODUCT TIER IS 1 AND ORDER BY PRICE", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("PRODUCT TIER IS 1 AND ORDER BY PRICE, SKIP 2 PRODUCTS AND TAKE 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First test1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SingleOrDefault test1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SingleOrDefault test2: " + r9);

        }

    }
}
