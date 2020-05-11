using System;
using System.Collections.Generic;
using System.Text;

namespace Secao16_ExpressoesLambda_Delegates_LINQ.Services
{
    class CalculationService
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Max(double a, double b)
        {
            return (a > b) ? a : b;
        }

        public static double Square(double a)
        {
            return a * a;
        }
    }
}
