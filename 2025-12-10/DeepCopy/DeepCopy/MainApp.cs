using System;

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass(); // 1. 원본 객체 생성 및 초기화 (10, 20)
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source; // 2. 얕은 복사: source의 '참조'만 target에 복사
                                         // 이제 source와 target은 메모리 상의 '같은 객체'를 가리킵니다.
                
                target.MyField2 = 30; // 3. target을 통해 객체의 필드 값을 30으로 변경
                                      // source와 target이 같은 곳을 보기 때문에, source의 값도 30으로 바뀝니다.

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass(); // 1. 원본 객체 생성 및 초기화 (10, 20)
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy(); // 2. 깊은 복사: 완전히 새로운 객체 생성
                                                    // source와 target은 이제 메모리 상의 '서로 다른 객체'를 가리킵니다.

                target.MyField2 = 30; // 3. target의 필드 값만 30으로 변경
                                      // target만 변경되고 source에는 아무런 영향을 주지 않습니다.

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}