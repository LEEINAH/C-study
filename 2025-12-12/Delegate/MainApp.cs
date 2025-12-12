using System;

namespace Delegate
{
    // delegate 선언
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // Calculator 클래스의 인스턴스 Calc를 생성
            Calculator Calc = new Calculator();

            // MyDelegate 타입의 변수 Callback을 선언
            MyDelegate Callback;

            // Callback 변수가 Calc 인스턴스의 Plus 메서드를 참조하도록 위임
            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            //Callback 변수가 Calculator 클래스의 정적 메서드 Minus를 참조하도록 다시 위임
            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}