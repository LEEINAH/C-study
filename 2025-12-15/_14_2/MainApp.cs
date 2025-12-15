using System;

namespace _14_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            // Action은 배열(a)을 매개변수로 받는다.
            Action<int[]> action = (a) =>
            {
                // 전달받은 배열 a를 사용하여 루프를 실행
                foreach (int i in a)
                {
                    Console.WriteLine(i * i);
                }

            };

            // action에 array를 전달한다.
            action.Invoke(array);
        }
    }
}