using System;
using System.Linq.Expressions;

namespace ExpressionTreeViaLambda
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expression = 
                (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();

            // a = 7, b = 8
            Console.WriteLine($"1 * 2 + ({7} - {8}) = {func(7, 8)}");
        }
    }
}