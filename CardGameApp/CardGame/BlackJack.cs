using System.Collections.Generic;

namespace CardGame
{
	internal partial class Program
	{
		public class BlackJack : Deck
		{
            public BlackJack()
			{
				CreateDeck();

				ShuffleDeck();
            }
            public override List<PlayingCardModel> DealCard()
			{
				List<PlayingCardModel> output = new List<PlayingCardModel>();

				for (int card = 0; card < 2; card++)
				{
					output.Add(DrawOneCard());
				}
				return output;
			}

			//creating a new method for BlackJack so that we can use the protected DrawOneCard method publicly
			public PlayingCardModel RequestCardForBlackJack()
			{
				return DrawOneCard();
			}
		}
	}
}
