using System;

namespace Test
{
    class MainApp
    {
        static double Square(double number)
        {
            number = number * number;
            return number;
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");

            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);

            Console.WriteLine($"결과 : {Square(number)}");
        }
    }
}