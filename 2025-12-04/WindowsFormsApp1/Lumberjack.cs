using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Lumberjack
	{
		private string name;
		public string Name { get { return name; } }
		private Stack<Flapjack> meal;
		public Lumberjack(string name)
		{
			this.name = name;
			meal = new Stack<Flapjack>();
		}
		public int FlapJackCount { get { return meal.Count; } }

		// TakeFlapjacks 메서드에서는 meal 스택의 내용을 갱신한다.
		public void TakeFlapjacks(Flapjack food, int howMany)
		{
			for (int i = 0; i < howMany; i++)
			{
				meal.Push(food);
			}
		}

		// EatFlapjacks 메서드에서는 while문을 돌려서 나무꾼이 먹은 팬케이크에 대한 정보를 출력한다.
		public void EatFlapjacks()
		{
			Console.WriteLine(name + "' s eating flapjacks");
			while (meal.Count > 0)
			{
				Console.WriteLine(name + " ate a "
					+ meal.Pop().ToString().ToLower() + " flapjack");
				// meal.Pop()은 열거형을 반환하는데, string 객체를 반환하기 위해 자신의 ToString() 메서드가 호출되며,
				// 또 다른 string 객체를 반환하기 위해 ToLower() 메서드가 호출됩니다.
			}
		}
	}
}
