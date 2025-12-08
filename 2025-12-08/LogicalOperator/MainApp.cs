using System;

namespace LogicalOperator
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// &&은 둘 다 true여야 true가 됨.
			Console.WriteLine("Testing && ...");
			Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}"); // True
			Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}"); // False
			Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}"); // False
			Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}"); // False

			// ||은 둘 중 하나만 true여도 true가 나옴.
			Console.WriteLine("\nTesting || ...");
			Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}"); // True
			Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}"); // True
			Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}"); // False
			Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}"); // True

			// !는 값을 반대로 바꿔줌.
			Console.WriteLine("\nTesting ! ...");
			Console.WriteLine($"!True : {!true}"); // False
			Console.WriteLine($"!False : {!false}"); // True
		}
	}
}