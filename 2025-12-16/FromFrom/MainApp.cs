using System;
using System.Linq;

namespace FromFrom
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                new Class() { Name = "연두반", Score = new int[] { 99, 80, 70, 24} },
                new Class() { Name = "분홍반", Score = new int[] { 60, 45, 87, 72} },
                new Class() { Name = "파랑반", Score = new int[] { 92, 30, 85, 94} },
                new Class() { Name = "노랑반", Score = new int[] { 90, 88, 0, 17} }
            };

            var classes = from c in arrClass                    // 1. c에 arrClass를 하나씩 담는다
                          from s in c.Score                     // 2. s에 score를 하나씩 담는다
                          where s < 60                          // 3. 60보다 이하인 점수를 찾는다
                          orderby s                             // 4. score 오름차순으로 정렬한다
                          select new { c.Name, Lowest = s };    // 5. 최종적으로 60점 이하인 학생의 이름과 점수를 새로운 형태의
                                                                //    객체로 생성하여 반환한다

            foreach ( var c in classes ) 
                Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
        }
    }
}