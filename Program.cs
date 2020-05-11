using Secao16_ExpressoesLambda_Delegates_LINQ.Services;
using System;

namespace Secao16_ExpressoesLambda_Delegates_LINQ
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
