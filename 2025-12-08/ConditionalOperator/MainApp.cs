using System;

namespace ConditionalOperator
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// 10 % 2 를 해서 값이 0이 나오는게 true면 : 기준 왼쪽에 있는 것을 출력 false면 오른쪽에 있는 것을 출력
			string result = (10 % 2) == 0 ? "짝수" : "홀수"; // 짝수

			Console.WriteLine(result);
		}
	}
}