using System;

namespace MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base // new 키워드로 부모 메서드를 숨김
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived(); // 1. 업캐스팅: 실제 객체는 Derived, 변수 타입: Base, 객체 타입: Derived
            baseOrDerived.MyMethod();           // 2. 메서드 호출

            // 컴파일러는 baseOrDerived 변수가 Base 타입인 것을 확인한다.
            // Base 타입이 가진 MyMethod()를 호출하도록 코드를 확정한다.
            // 비록 실제 객체가 Derived이더라도, 메서드 숨김에서는 다형성이 적용되지 않으므로,
            // 숨겨진 Derived.MyMethod()는 무시된다.
        }
    }
}