using System;

namespace Test2
{
    class MainApp
    {
        public static void Main()
        {
            double mean = 0;

            Console.WriteLine("평균 : {0}", Mean(1, 2, 3, 4, 5, mean));
        }

        public static double Mean (
            double a, double b, double c,
            double d, double e, double mean)
        {
            mean = (a + b + c + d + e) / 5;
            return mean;
        }
    }
}