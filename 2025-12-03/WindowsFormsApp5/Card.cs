using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
	// 따로 값을 지정하지 않으면 첫 번째 값이 0이 되고,
	// 두 번째 값은 1, 다음 값은 2 이런 식으로 값이 자동으로 지정됩니다.
	enum Suits
	{
		Spades,
		Clubs,
		Diamonds,
		Hearts
	}

	// Ace를 1로 지정하는 것으로 시작해서 카드에서 나올 수 있는 모든 값을 열거하고 있다.
	enum Values
	{
		Ace = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
		Jack = 11,
		Queen = 12,
		King = 13,
	}

	class Card
	{

		// Card 클래스에 들어가는 코드이므로 Card.Suits, Card.Values라고 할 필요 없이
		// 그냥 Suite, Values라고 쓰면 됨.
		public Suits Suit { get; set; }
		public Values Value { get; set; }

		public Card(Suits suit, Values value) 
		{
			this.Suit = suit;

			this.Value = value;
		}

		// Name 속성의 get 접근자를 만들 때는 enum의 ToString() 메서드에서
		// 열거자 이름을 문자열로 변환한 것을 반환하는 ToString() 메서드를 활용함.
		public string Name
		{
			get { return Value.ToString() + " of " + Suit.ToString(); }
		}

		internal static string Plural(Values value)
		{
			return value.ToString();
		}
	}
}
