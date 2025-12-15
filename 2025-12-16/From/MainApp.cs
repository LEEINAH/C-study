using System;
using System.Linq;

namespace Linq
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // Linq 키워드 정리
            // form : 데이터 원본을 지정하고 반복 변수를 설정
            // where : 지정된 조건에 맞는 요소만 걸러내는 필터 역할
            // orderby : 걸러진 요소를 특정 기준에 따라 정렬
            // select : 최종적으로 결과로 반환할 항목의 형태를 결정

            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers  // 1. numbers에서 각 숫자를 n이라고 부르며 시작
                         where n % 2 == 0   // 2. 그 n이 짝수일 때만 선택
                         orderby n          // 3. 선택된 짝수들을 n 기준으로 오름차순 정렬
                         select n;          // 4. 최종적으로 그 n(짝수)을 결과로 반환

            foreach (int n in result)
                Console.WriteLine($"짝수 : {n}");
        }
    }
}