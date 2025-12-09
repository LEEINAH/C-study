using System;

namespace Test2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요 : ");

            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);

            if (number <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                return;
            }
            
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (i == j || i > j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}