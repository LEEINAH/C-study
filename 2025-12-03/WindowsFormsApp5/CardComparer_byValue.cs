using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace WindowsFormsApp5
{
	class CardComparer_byValue : IComparer<Card>
	{
		public int Compare(Card x, Card y)
		{
			// x 값이 y 값보다 더 크면 1을, 더 작으면 -1을 반환한다.
			// 어느 쪽이든 return 선언문이 실행되면 메서드가 바로 종료된다.
			if (x.Value < y.Value)
			{
				return -1;
			}
			if (x.Value > y.Value)
			{
				return 1;
			}
			// 이 부분은 두 카드의 값(숫자와 A, J, Q, K)이 같을 때만 실행된다.
			// 위에 있는 두 개의 return 선언문이 둘 다 실행되지 않은 경우에만 여기까지 올 수 있다.
			if (x.Suit < y.Suit)
			{
				return -1;
			}
			if (x.Suit > y.Suit)
			{
				return 1;
			}
			// 위에 있는 네 개의 return 문 중 어느 것도 실행되지 않은 경우에는 두 카드가 같으므로 0을 반환한다.
			return 0;
		}
	}
}
