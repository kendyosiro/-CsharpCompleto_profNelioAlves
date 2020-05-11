using Secao16_ExpressoesLambda_Delegates_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Secao16_ExpressoesLambda_Delegates_LINQ
{

    //Fazer um programa que, a partir de uma lista de produtos, gere
    //uma nova lista contendo os nomes dos produtos em caixa alta.
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();
            produtos.Add(new Product("TV", 1200.00));
            produtos.Add(new Product("Mesa", 400.00));
            produtos.Add(new Product("Geladeira", 2300.00));
            produtos.Add(new Product("Cadeira", 390.00));

            //1-utilizando Select passando função como argumento
            //List<string> results = produtos.Select(NameUpper).ToList();

            //2-criando uma Func que recebe um Product e retorna um string e passa no select o nome da func:
            //Func<Product, string> func = NameUpper;
            //List<string> results = produtos.Select(func).ToList();

            //3-criando uma Func utilizando expressão lambda:
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> results = produtos.Select(func).ToList();

            //se eu colocar chaves na funcao, tenho que colocar a palavra return:
            // Func<Product, string> func = p => { return p.Name.ToUpper(); };
            // List<string> results = produtos.Select(func).ToList();

            //a forma mais fácil é utiliza a expressão lambda dentro do select:
            List<string> results = produtos.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in results)
            {
                System.Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
