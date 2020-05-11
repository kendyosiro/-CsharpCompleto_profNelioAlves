using System;

namespace Secao16_ExpressoesLambda_Delegates_LINQ.Services
{
    class CalculationService
    {
        public static void ShowSum(double a, double b)
        {
            double sum =  a + b;
            Console.WriteLine($"A soma dos números {a} e {b} é igual a {sum}.");
        }

        public static void ShowMax(double a, double b)
        {
            double bigger = (a > b) ? a : b;
            Console.WriteLine($"O maior entre {a} e {b} é {bigger}.");
        }

        public static double Square(double a)
        {
            return a * a;
        }
    }
}
