using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
	class Game
	{
		private List<Player> players;
		private Dictionary<Values, Player> books;
		private Deck stock;
		private TextBox textBoxOnForm;

		public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
		{
			Random random = new Random();
			this.textBoxOnForm = textBoxOnForm;
			players = new List<Player>();
			players.Add(new Player(playerName, random, textBoxOnForm));
			foreach (string player in opponentNames)
				players.Add(new Player(player, random, textBoxOnForm));
			books = new Dictionary<Values, Player>();
			stock = new Deck();
			Deal();
			players[0].SortHand();
		}

		// Deal() 메서드는 게임이 처음 시작될 때 호출된다.
		// 카드를 섞고 플레이어마다 다섯 장씩 나눠준다.
		// 그리고 각 플레이어가 처음에 받은 카드 중에 북이 완성된 게 있으면 북을 뽑아낸다.
		private void Deal()
		{
			stock.Shuffle();
			for (int i = 0; i < 5; i++)
				foreach (Player player in players)
					player.TakeCard(stock.Deal());
			foreach (Player player in players)
				PullOutBooks(player);
		}

		public bool PlayOneRound(int selectedPlayerCard)
		{
			Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
			for (int i = 0; i < players.Count; i++)
			{
				if (i == 0)
					players[0].AskForACard(players, 0, stock, cardToAskFor);
				else
					players[i].AskForACard(players, i, stock);

				
				if (PullOutBooks(players[i]))
				{
					// 다른 플레이어들에게 카드를 요구해서 받아온 다음 북이 완성됐느면 뽑아낸다.
					// 그러고 나서 그 플레이어가 가진 카드가 다 떨어졌으면 스톡으로부터 최대 다섯장까지 카드를 가져온다.
					textBoxOnForm.Text += players[i].Name
								  // 플레이어가 "Ask for a card" 버튼을 클릭하면 선택된 카드로 AskForACard() 메서드를 호출한다.
								  // 그러고 나서 나머지 컴퓨터 플레이어들에 대해서 AskForACard() 메서드를 호출한다.
								  + "님이 새로운 손을 그렸습니다." + Environment.NewLine;
					int card = 1;
					while (card <= 5 && stock.Count > 0)
					{
						players[i].TakeCard(stock.Deal());
						card++;
					}
				}
				// 한 라운드를 진행하고 나면 플레이어의 패를 정렬해서 화면에 정렬된 순서대로 표시되게 만든다.
				// 그리고 게임이 끝났는지 확인하고, 게임이 끝났으면 참을 반환한다.
				players[0].SortHand();
				if (stock.Count == 0)
				{
					textBoxOnForm.Text =
						"남은 카드가 없습니다. 게임 오버!" + Environment.NewLine;
					return true;
				}
			}
			return false;
		}

		// PullOutBooks() 메서드에서는 해당 플레이어가 같은 값을 가진 카드를 네 장 가지고 있는지 확인해 본다.
		// 만약 북을 완성할 수 있으면 완성된 북을 books 딕셔너리에 저장한다.
		// 그리고 그 플레이어의 카드가 다 떨어졌으면 참을 반환한다.
		public bool PullOutBooks(Player player)
		{
			IEnumerable<Values> booksPulled = player.PullOutBooks();
			foreach (Values value in booksPulled)
				books.Add(value, player);
			if (player.CardCount == 0)
				return true;
			return false;
		}

		// 완성된 북 목록을 폼에 표시해야 한다. 
		//이 메서드에서 딕셔너리에 저장된 목록을 문자열 형태로 바꿔준다.
		public string DescribeBooks()
		{
			string whoHasWhichBooks = "";
			foreach (Values value in books.Keys)
				whoHasWhichBooks += books[value].Name + " 책을 가지고 있다 "
					+ Card.Plural(value) + Environment.NewLine;
			return whoHasWhichBooks;
		}

		// 스톡 카드가 다 떨어지면 누가 게임에서 이겼는지 파악해야 한다.
		// GetWinnerName() 메서드가 그 작업을 해주는 메서드.
		// 이 메서드에서는 winners라는 딕셔너리를 만들어서 그 작업을 한다.
		// 딕셔너리에서 각 플레이어의 이름을 키로, 그 플레이어가 완성한 북 개수를 값으로 저장한다.
		public string GetWinnerName()
		{
			Dictionary<string, int> winners = new Dictionary<string, int>();
			foreach (Values value in books.Keys)
			{
				string name = books[value].Name;
				if (winners.ContainsKey(name))
					winners[name]++;
				else
					winners.Add(name, 1);
			}

			// 여기에서는 우승자가 완성한 북 개수를 파악한다. 그 값을 mostBooks 변수에 저장한다.
			int mostBooks = 0;
			foreach (string name in winners.Keys)
				if (winners[name] > mostBooks)
					mostBooks = winners[name];
			bool tie = false;
			string winnerList = "";
			foreach (string name in winners.Keys)
				if (winners[name] == mostBooks)
				{
					if (!String.IsNullOrEmpty(winnerList))
					{
						winnerList += " and ";
						tie = true;
					}
					winnerList += name;
				}
			winnerList += " with " + mostBooks + " books";
			if (tie)
				return "공동 우승자 " + winnerList;
			else
				return winnerList;
		}

		public IEnumerable<string> GetPlayerCardNames()
		{
			return players[0].GetCardNames();
		}

		public string DescribePlayerHands()
		{
			string description = "";
			for (int i = 0; i < players.Count; i++)
			{
				description += players[i].Name + " has " + players[i].CardCount;
				if (players[i].CardCount == 1)
					description += " card." + Environment.NewLine;
				else
					description += " cards." + Environment.NewLine;
			}
			description += "The stock has " + stock.Count + " cards left.";
			return description;
		}
	}
}
