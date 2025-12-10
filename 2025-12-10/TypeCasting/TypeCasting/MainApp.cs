using System;

namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog(); // mammal 변수는 Dog 객체를 담고 있다.
            Dog    dog;

            if (mammal is Dog) // mammal이 Dog 타입인지 확인
            {
                dog = (Dog)mammal; // Dog 타입으로 강제 형변환 (다운캐스팅)
                dog.Bark();        // Dog의 고유 메서드 호출
            }

            Mammal mammal2 = new Cat(); // mammal2 변수는 Cat 객체를 담고 있다.

            Cat cat = mammal2 as Cat; // mammal2를 Cat으로 변환 시도
            if (cat != null)
                cat.Meow();           // Cat의 고유 메서드 호출

            // 첫 번째 블록에서 이미 선언됨: Mammal mammal = new Dog(); (Dog 객체)
            Cat cat2 = mammal as Cat; // mammal (Dog 객체)를 Cat으로 변환 시도
            if (cat2 != null)
                cat2.Meow();
            else 
                Console.WriteLine("cat2 is not a Cat"); // 변환 실패 시 실행
        }
    }
}