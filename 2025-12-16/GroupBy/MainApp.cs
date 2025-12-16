using System;
using System.Linq;

namespace GroupBy
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
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 }
            };

            var listProfile = from profile in arrProfile                     // 1. profile에 arrProfile을 담고
                              orderby profile.Height                         // 2. 키 순으로 정렬한 뒤
                              group profile by profile.Height < 175 into g   // 3. profile에 담긴 값을 키가 175보다 작은지
                                                                             //    true, false로 구분지어 그룹으로 묶고
                              select new { GroupKey = g.Key, Profiles = g }; // 4. 최종적으로 true, false가 담긴 키 값과 그 값에 해당하는 객체들에
                                                                             //    이름을 새로 지어 새로운 형태의 객체로 만들어준다

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($"    {profile.Name}, {profile.Height}");
                }
            }
        }
    }
}