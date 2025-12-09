using System;

namespace DoWhile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                Console.WriteLine("b) i : {0}", i--); // 여기서 i는 이미 0이지만 한 차례 더 실행.
            }
            while (i > 0);
        }
    }
}