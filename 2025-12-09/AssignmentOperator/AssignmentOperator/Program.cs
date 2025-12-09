using System;

namespace AssignmentOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;
            Console.WriteLine($"a = 100 : {a}");
            a += 90;
            Console.WriteLine($"a += 90 : {a}"); // a += 90은 a = a + 90과 동일
            a -= 80;
            Console.WriteLine($"a -= 80 : {a}"); // a -= 80은 a = a - 80과 동일
            a *= 70;
            Console.WriteLine($"a *= 70 : {a}"); // a *= 70은 a = a * 70과 동일
            a /= 60;
            Console.WriteLine($"a /= 60 : {a}"); // a /= 60은 a = a / 60과 동일
            a %= 50;
            Console.WriteLine($"a %= 50 : {a}"); // a %= 50은 a = a % 50과 동일
            a &= 40;
            Console.WriteLine($"a &= 40 : {a}"); // a &= 40은 a = a & 40과 동일 (비트연산자)
            a |= 30;
            Console.WriteLine($"a |= 30 : {a}"); // a |= 30은 a = a | 30과 동일 (비트연산자)
            a ^= 20;
            Console.WriteLine($"a ^= 20 : {a}"); // a ^= 20은 a = a ^ 20과 동일 (비트연산자)
            a <<= 10;
            Console.WriteLine($"a <<= 10 : {a}"); // a <<= 10은 a = a << 10과 동일 (비트연산자)
            a >>= 1;
            Console.WriteLine($"a >>= 1 : {a}"); // a >>= 1은 a = a >> 1과 동일 (비트연산자)
        }
    }
}