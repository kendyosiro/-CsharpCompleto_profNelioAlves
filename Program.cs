using Secao16_ExpressoesLambda_Delegates_LINQ.Entities;
using Secao16_ExpressoesLambda_Delegates_LINQ.Services;
using System.Collections.Generic;

namespace Secao16_ExpressoesLambda_Delegates_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("TV", 1200.00);
            Product p2 = new Product("Mesa", 400.00);
            Product p3 = new Product("Geladeira", 2300.00);
            Product p4 = new Product("Cadeira", 390.00);

            List<Product> produtos = new List<Product>();
            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);
            produtos.Add(p4);

            //Somente este comando resolveria:
            //produtos.RemoveAll(x => x.Price < 1000.00);

            produtos.RemoveAll(TestProduct);

            foreach (Product product in produtos)
            {
                System.Console.WriteLine(product.ToString());
            }
        }

        static bool TestProduct(Product p)
        {
            return p.Price < 1000.00;
        }
    }
}
