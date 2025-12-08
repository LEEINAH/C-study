using System;
using static System.Console;

namespace BrainCSharp
{
	class Hi
	{
		// 프로그램 실행이 시작되는 곳
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("사용법 : Hi.exe <여러분>");
				return;
			}

			WriteLine("{0}, 안녕하세요?\n반갑습니다!", args[0]);
		}
	}
}