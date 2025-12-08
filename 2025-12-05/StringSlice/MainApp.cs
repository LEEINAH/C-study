using System;
using static System.Console;

namespace StringSlice
{
	class MainApp
	{
		static void Main(string[] args)
		{
			string greeting = "Good morning.";

			// 원 글의 0번째(G)부터 5개의 글자를 표시함(Good ) 
			WriteLine(greeting.Substring(0, 5)); // "Good "
			// 원 글의 5번째(m) 이후 글자를 모두 표시함
			WriteLine(greeting.Substring(5)); // "morning."
			WriteLine();

			// " "을 기준으로 문자를 나눔
			string[] arr = greeting.Split(
				new string[] { " " }, StringSplitOptions.None);
			WriteLine("Word Count : {0}", arr.Length);

			// arr의 각 요소를 하나씩 가져와 element라는 변수에 저장한다.
			foreach (string element in arr)
				WriteLine("{0}", element);

		}
	}
}