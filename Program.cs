using Secao16_ExpressoesLambda_Delegates_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Secao16_ExpressoesLambda_Delegates_LINQ
{

    //Utilizando LINQ para obter os números pares de uma lista
    //e esses números são multiplicados por 10

    class Program
    {
        static void Main(string[] args)
        {
            //1-specify a data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define a query expression:
            IEnumerable<int> list = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Executing the query defined:
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}
