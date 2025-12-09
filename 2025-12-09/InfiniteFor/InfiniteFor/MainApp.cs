using System;

namespace InfiniteFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 0;
            // for의 세 부분(초기화, 조건, 증감) 모두 생략되었기 때문에 무한루프가 돈다.
            for (; ; )
                Console.WriteLine(i++);
        }
    }
}