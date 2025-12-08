using System;

namespace IntegralTypes
{
	class MainApp
	{
		static void Main(string[] args)
		{
			sbyte a = -10;
			byte b = 40;

			Console.WriteLine($"a={a}, b={b}");

			short c = -30000;
			ushort d = 60000;

			Console.WriteLine($"c={c}, d={d}");

			// 큰 자릿수의 정수 리터럴을 타이핑할 때는 자릿수 구분자(_)를 이용하면 편리하다.
			int e = -1000_0000; // 0이 7개
			uint f = 3_0000_0000; // 0이 8개

			Console.WriteLine($"e={e}, f={f}");

			long g = -5000_0000_0000; // 0이 11개
			ulong h = 200_0000_0000_0000_0000; // 0이 18개

			Console.WriteLine($"={g}, h={h}");
		}
	}
}