using static System.Console;

namespace StringModify
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// 소문자로 바꿈
			WriteLine("Lower() : '{0}'", "ABC".ToLower());
			// 대문자로 바꿈
			WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

			// 글자를 삽입함 (5, " Sunny" 니까 원 글의 5번째 글자(공백)부터 추가함)
			WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
			// 글자를 삭제함 (2, 6 이니까 원 글의 두번째 글자(공백)를 1번으로 치고 6번째 글자까지 삭제함)
			WriteLine("Remove() : '{0}'", "I Don't Love you.".Remove(2, 6));

			// 앞 뒤 공백을 제거함
			WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
			// 앞 공백을 제거함
			WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
			// 뒤 공백을 제거함
			WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());
		}
	}
}