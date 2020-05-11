using Secao16_ExpressoesLambda_Delegates_LINQ.Entities;
using Secao16_ExpressoesLambda_Delegates_LINQ.Services;
using System;
using System.Collections.Generic;

namespace Secao16_ExpressoesLambda_Delegates_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();
            produtos.Add(new Product("TV", 1200.00));
            produtos.Add(new Product("Mesa", 400.00));
            produtos.Add(new Product("Geladeira", 2300.00));
            produtos.Add(new Product("Cadeira", 390.00));

            //Formas de resolucao:
            //1-criação de um Action:
            //Action<Product> act = UpdatePrice;
            //produtos.ForEach(act);

            //2-passando um método void:
            //produtos.ForEach(UpdatePrice);

            //3-passando uma expressão lambda. Neste caso, não precisaria da funcao UpdatePrice:
            produtos.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product product in produtos)
            {
                System.Console.WriteLine(product.ToString());
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
