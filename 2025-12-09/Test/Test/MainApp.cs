using System;

namespace Test
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 5; j > 0; j--)
                {
                    if (j == i || j < i)
                    {
                        Console.Write("*");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}