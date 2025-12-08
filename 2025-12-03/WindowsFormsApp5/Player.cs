using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
	class Player
	{
		private string name;
		public string Name { get { return name; } }
		private Random random;
		private Deck cards;
		private TextBox textBoxOnForm;

		// Player 클래스 생성자. private 필드를 설정하고 게임에 참가한 플레이어 정보를 텍스트상자에 출력한다. 
		public Player(String name, Random random, TextBox textBoxOnForm)
		{
			this.name = name;
			this.random = random;
			this.textBoxOnForm = textBoxOnForm;
			this.cards = new Deck( new Card[] {} );
			textBoxOnForm.Text += name +
				"님이 방금 게임에 합류했습니다." + Environment.NewLine;
		} 

		public IEnumerable<Values> PullOutBooks()
		{
			List<Values> books = new List<Values>();
			for (int i = 1; i <= 13;  i++)
			{
				Values value = (Values)i;
				int howMany = 0;
				for (int card = 0; card < cards.Count; card++)
					if (cards.Peek(card).Value == value)
						howMany++;
				if (howMany == 4)
				{
					books.Add(value);
					cards.PullOutValues(value);
				}
			}
			return books;
		}

		// GetRandomValue() 메서드에서는 Peek() 메서드로 플레이어가 가지고 있는 카드 가운데 하나를 랜덤으로 알아냄.
		public Values GetRandomValue()
		{
			Card randomCard = cards.Peek(random.Next(cards.Count));
			return randomCard.Value;
		}

		// DoYouHaveAny() 메서드에서는 PullOutValues() 메서드로 주어진 매개변수와
		// 같은 값을 가지는 모든 카드를 뽑아내서 반환함.
		public Deck DoYouHaveAny(Values value)
		{
			Deck cardsIHave = cards.PullOutValues(value);
			textBoxOnForm.Text += Name + " has " + cardsIHave.Count + " "
				+ Card.Plural(value) + Environment.NewLine;
			return cardsIHave;
		}

		// 상대방이 마지막 카드를 포기한다면, GetRandomValue()는
		// 비어있는 한 벌의 카드에서 Deal() 호출을 시도한다. 이 메서드에서 그런 일을 방지한다.
		public void AskForACard(List<Player> players, int myIndex, Deck stock)
		{
			if (stock.Count > 0)
			{
				if (cards.Count == 0)
					cards.Add(stock.Deal());
				Values randomValue = GetRandomValue();
				AskForACard(players, myIndex, stock, randomValue);
			}
		}

		// 카드가 하나도 넘어오지 않았으면 Deal() 메서드로 스톡에서 카드를 한 장 가져옵니다.
		public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
		{
			textBoxOnForm.Text += Name + "님이 카드를 가지고 있는지 묻습니다. "
											+ value + Environment.NewLine;
			int totalCardsGiven = 0;
			for (int i = 0; i < players.Count; i++)
			{
				if (i != myIndex)
				{
					Player player = players[i];
					Deck CardsGiven = player.DoYouHaveAny(value);
					totalCardsGiven += CardsGiven.Count;
					while (CardsGiven.Count > 0)
						cards.Add(CardsGiven.Deal());
				}
			} 
			if (totalCardsGiven == 0 && stock.Count > 0)
			{
				textBoxOnForm.Text += Name +
					"님이 카드를 뽑았습니다." + Environment.NewLine;
				cards.Add(stock.Deal());
			}
		}

		public int CardCount { get { return cards.Count; } }
		public void TakeCard(Card card) { cards.Add(card); }
		public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
		public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
		public void SortHand() { cards.SortByValue(); }
	}
}
