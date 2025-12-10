using System;

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this() // 이 생성자를 호출하기 전에 this() (기본 생성자)를 먼저 호출한다.
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b) // 이 생성자를 호출하기 전에 this(b) (매개변수 한 개인 생성자)를 먼저 호출한다.
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}. {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a : {a}, b : {b}, c : {c}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}