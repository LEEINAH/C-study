using System;
using static System.Console;

namespace StringFormatBasic
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// fmt 변수는 WriteLine 메소드가 데이터를 출력할 때 사용할 형식을 정의함.
			// {} 안에 있는 숫자 중 앞에 있는 숫자는 인덱스(Index)를, 뒤에 있는 숫자는 필드 너비(Field Width)를 나타냄.
			string fmt = "{0,-20}{1,-15}{2, 30}";

			// fmt 형식에 맞춰 글자를 출력함
			WriteLine(fmt, "Publisher", "Author", "Title");
			WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
			WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
			WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
		}
	}
}