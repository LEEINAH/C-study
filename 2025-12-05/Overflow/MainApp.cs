using System;
using System.Formats.Asn1;

namespace Overflow
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// uint의 최대값, 4294967295;
			uint a = uint.MaxValue;

			Console.WriteLine(a);

			a = a + 1;

			Console.WriteLine(a);
		}
	}
}