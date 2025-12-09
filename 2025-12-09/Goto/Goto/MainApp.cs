using System;

namespace Goto
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("종료 조건(숫자)을 입력하세요 : ");

            String input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);

            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number) // 조건이 참이면 33행으로 점프
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM; // 33행의 EXIT_FOR를 만나지 않기 위해 36행으로 점프한다. 

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");
        }
    }
}