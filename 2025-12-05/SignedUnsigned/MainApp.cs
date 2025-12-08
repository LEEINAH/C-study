using System;

namespace SignedUnsigned
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// byte 형식 255는 1111 1111
			byte a = 255;
			// (sbyte)는 변수를 sbyte 형식으로 변환하는 연산자
			sbyte b = (sbyte)a;
			
			Console.WriteLine(a);
			Console.WriteLine(b);
		}
	}
}