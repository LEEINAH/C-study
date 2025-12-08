using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Game game;

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textName.Text))
			{
				MessageBox.Show("이름을 입력해주세요.", "아직 게임을 시작할 수 없습니다");
				return;
			}
			// 게임이 시작되면 Game 클래스 인스턴스를 새로 만들고,
			// "Ask for a card" 버튼을 활성화하고,
			// "Start Game" 버튼을 비활성 상태로 돌리고, 폼을 다시 그린다.
			game = new Game(textName.Text, new List<string> { "철수", "유리" }, textProgress);
			buttonStart.Enabled = false;
			textName.Enabled = false;
			buttonAsk.Enabled = true;
			UpdateForm();
		}

		// 이 메서드에서는 플레이어가 가지고 있는 패가 저장된 ListBox를 지우고
		// 내용을 다시 채워 넣은 후 텍스트상자의 내용을 갱신한다.
		private void UpdateForm()
		{
			listHand.Items.Clear();
			foreach (String cardName in game.GetPlayerCardNames())
				listHand.Items.Add(cardName);
			textBooks.Text = game.DescribeBooks();
			// 이런식으로 SelectionStart 속성을 설정하고 ScrollToCaret() 메서드를 호출하면
			// 텍스트상자에 텍스트가 너무 많아서 한 화면을 넘어가야 하는 경우에는 
			// 맨 아래쪽으로 스크롤된 상태로 만들어 줄 수 있다.
			textProgress.Text += game.DescribePlayerHands();
			textProgress.SelectionStart = textProgress.Text.Length;
			textProgress.ScrollToCaret();
		}

		private void buttonAsk_Click(object sender, EventArgs e)
		{
			textProgress.Text = "";
			if (listHand.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a card");
				return;
			}
			if (game.PlayOneRound(listHand.SelectedIndex))
			{
				textProgress.Text += "승자는... " + game.GetWinnerName();
				textBooks.Text = game.DescribeBooks();
				buttonAsk.Enabled = false;
				// 플레이어는 카드를 한 장 선택한 다음 "Ask for a card" 버튼을 클릭해서
				// 같은 숫자의 카드를 가진 사람이 있는지 확인한다. 
				// Game 클래스에서는 PlayOneRound() 메서드로 한 라운드를 진행한다.
			}
			else
				UpdateForm();
		}
	}
}
