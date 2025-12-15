using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171}
            };

            var profiles = from profile in arrProfile // 1. profile에 arrProfile에 담긴 값을 하나씩 담고
                           where profile.Height < 175 // 2. 그 중에 Height가 175보다 작은걸 거르고
                           orderby profile.Height     // 3. 오름차순으로 정렬한 뒤
                           select new                 // 4. 최종적으로 이름과 키를 인치로 변환한 새로운 형태의 
                           {                          //    객체를 생성하여 반환한다
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach (var profile in profiles) 
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }
}