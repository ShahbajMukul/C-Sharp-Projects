using System;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			PokerDeck pokerGame = new PokerDeck();

			var hand = pokerGame.DealCard();

			foreach (var card in hand)
			{
                Console.WriteLine(card.Value.ToString() + " of "  + card.Suit.ToString() );
            }

            Console.WriteLine(Environment.NewLine);

			BlackJack blackJackGame = new BlackJack();

			 var handofBlackJack = blackJackGame.DealCard();

			foreach (var card in handofBlackJack)
			{
				Console.WriteLine(card.Value.ToString() + " of " + card.Suit.ToString());
			}

			Console.ReadLine();
		}
	}
}
