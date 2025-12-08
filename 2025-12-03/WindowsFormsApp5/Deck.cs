using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
	class Deck
	{
		private List<Card> cards;
		private Random random = new Random();

		// 52장의 카드를 가진 deck을 생성하는 생성자.
		//중첩된 루프를 사용하는데 외부 루프는 4개의 suit에 대해 돌고 있다.
		// 내부 루프의 값이 13이니까 결국 1개의 suit에 대해 13번, 총 52번의 루프를 돈다.
		public Deck()
		{
			cards = new List<Card>();
			for (int suit = 0; suit <= 3; suit++)
				for (int value = 1; value <= 13; value++)
					cards.Add(new Card((Suits)suit, (Values) value));
		}

		// 이 생성자는 서로 다른 식으로 객체를 생성하는 오버로드됨.
		public Deck(IEnumerable<Card> initialCards)
		{
			cards = new List<Card>(initialCards);
		}

		public int Count { get { return cards.Count; } }

		// Add를 호출해서 카드를 추가함
		public void Add(Card cardToAdd)
		{
			cards.Add(cardToAdd);
		}

		// RemoveAt을 호출해서 카드를 제거함
		public Card Deal(int index)
		{
			Card CardToDeal = cards[index];
			cards.RemoveAt(index);
			return CardToDeal;
		}

		// Shuffle() 메서드에서는 NewCards라는 List<Cards>의 새 인스턴스를 생성한다.
		// 그리고 카드가 소진될 때까지 cards 필드에서 무작위 카드를 뽑아 NewCards에 집어넣는다.
		// 반복문을 다 돌고 나면 새 인스턴스를 가리키도록 cards 필드를 재설정한다.
		// 그러면 기존 인스턴스를 가리키는 참조변수가 없어지므로 그 객체는 가비지 컬렉터에 의해 소거된다.
		public void Shuffle()
		{
			List<Card> newCards = new List<Card>();
			while (cards.Count > 0)
			{
				int CardToMove = random.Next(cards.Count);
				newCards.Add(cards[CardToMove]);
				cards.RemoveAt(CardToMove);
			}
			cards = newCards;
		}

		// GetCardNames() 메서드에서는 모든 카드 이름을 다 집어넣을 수 있을 만큼 충분히 큰 배열을 만들어야한다.
		// 여기서는 for문을 사용하고 있지만, foreach문을 사용해도 된다.
		public IEnumerable<string> GetCardNames()
		{
			string[] CardNames = new string[cards.Count];
			for (int i = 0; i < cards.Count; i++)
				CardNames[i] = cards[i].Name;
			return CardNames;
		}

		public void Sort()
		{
			//cards.Sort(new CardComparer_bySuit());
		}

		// Deal() 메서드로 카드를 빼지 않고도 그 자리에 있는 카드가 무엇인지 알아내기 위한 메서드
		public Card Peek(int cardNumber)
		{
			return cards[cardNumber];
		}

		// 편의상 매개변수를 넘겨주지 않으면 맨 위에 있는 카드를 빼 줄 수 있게 Deal() 메서드를 오버로드
		public Card Deal()
		{
			return Deal(0);
		}

		// 특정 값을 가지는 카드가 있는지 검색하는 메서드.
		// 그 값을 가지는 카드가 있으면 참을 반환함.
		public bool ContainsValue(Values value)
		{
			foreach (Card card in cards) 
				if (card.Value == value)
					return true;
			return false;
		}

		// 한 플레이어가 가지고 있는 카드 중에서 북이 완성되어 같은 숫자 네 장을 뽑아내야 할 때 이 메서드를 사용함.
		// 특정 숫자에 해당하는 카드를 전부 찾아서 따로 빼서 별도의 Deak 객체에 집어넣어 반환함.
		public Deck PullOutValues(Values value)
		{
			Deck deckToReturn = new Deck(new Card[] { });
			for (int i = cards.Count -1; i >= 0; i--)
				if (cards[i].Value == value)
					deckToReturn.Add(Deal(i));
			return deckToReturn;
		}

		// HasBook() 메서드에서는 Deak 객체에 매개변수로 전달된 값을 가지는 카드가 네 장 있는지 확인하여 
		// 북이 완성됐는지를 판단함.
		// 그 객체에 해당 값으로 북이 완성되어 있으면 참을, 그렇지 않으면 거짓을 반환함.
		public bool HasBook(Values value)
		{
			int NumberOfCards = 0;
			foreach (Card card in cards)
				if (card.Value == value)
					NumberOfCards++;
			if (NumberOfCards == 4)
				return true;
			else
				return false;
		}

		// SortByValue() 메서드에서는 CardComparer_byValue 클래스로 이 Deak 객체에 있는 카드들을 정렬한다.
		public void SortByValue()
		{
			cards.Sort(new CardComparer_byValue());
		}
	}


}
