using Secao16_ExpressoesLambda_Delegates_LINQ.Services;

namespace Secao16_ExpressoesLambda_Delegates_LINQ
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}
