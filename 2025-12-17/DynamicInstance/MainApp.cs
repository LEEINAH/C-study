using System;
using System.Reflection;

namespace DynamicInstance
{
    class Profile
    {
        private string name;
        private string phone;

        public Profile()
        {
            name = "";
            phone = "";
        }

        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{name}, {phone}");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; } 
            set { phone = value; }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // 1. Type 객체 가져오기
            Type type = Type.GetType("DynamicInstance.Profile");

            // 2. 멤버 정보 가져오기
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("Phone");

            // --- 첫 번째 인스턴스 생성 및 사용 (매개변수 있는 생성자) ---

            // 3. 인스턴스 동적 생성 (1)
            object profile = Activator.CreateInstance(type, "박상현", "512-1234");

            // 4. 메서드 동적 호출
            methodInfo.Invoke(profile, null);

            // --- 두 번째 인스턴스 생성 및 사용 (기본 생성자) ---

            // 5. 인스턴스 동적 생성 (2)
            profile = Activator.CreateInstance(type);

            // 6. 속성 값 설정 (Setter 동적 호출)
            nameProperty.SetValue(profile, "박찬호", null);
            phoneProperty.SetValue(profile, "997-5511", null);

            // 7. 속성 값 읽기 및 출력 (Getter 동적 호출)
            Console.WriteLine("{0}, {1}",
                nameProperty.GetValue(profile, null),
                phoneProperty.GetValue(profile, null));
        }
    }
}