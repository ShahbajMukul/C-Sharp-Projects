using System.Collections.Generic;

namespace CardGame
{
	internal partial class Program
	{
		public class PokerDeck : Deck
		{
            public PokerDeck()
            {
				CreateDeck();
				ShuffleDeck();
            }

            public override List<PlayingCardModel> DealCard()
			{
				List<PlayingCardModel> output = new List<PlayingCardModel>();

				for (int index = 0; index < 5; index++)
				{
					output.Add(DrawOneCard());
				}

				return output;
			}

			public List<PlayingCardModel> RequestCardsForPoker(List<PlayingCardModel> cardsToDiscard)
			{
				List<PlayingCardModel> output = new List<PlayingCardModel>() ;

				foreach (var card in cardsToDiscard)
				{
					output.Add(DrawOneCard());
					discardPile.Add(card);
				}

				return output;
			}
		}
	}
}
