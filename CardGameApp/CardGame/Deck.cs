using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
	internal partial class Program
	{
		public abstract class Deck
		{
			protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
			protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
			protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();
			protected void CreateDeck()
			{
				fullDeck.Clear();

				for (int suit = 0; suit < 4; suit++)
				{
					for (int val = 0; val < 13; val++)
					{
						fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val });
					}
				}
				
			}

			public virtual void ShuffleDeck()
			{
				Random random = new Random();
				drawPile = fullDeck.OrderBy(card => random.Next()).ToList();
			}

			public int GetOrder(PlayingCardModel card)
			{
				if (card.Suit == CardSuit.Clubs)
				{
					return 1;
				}
				else
				{
					return 0;
				}
			}
			public abstract List<PlayingCardModel> DealCard();
			
			protected virtual PlayingCardModel DrawOneCard()
			{
				PlayingCardModel output = drawPile.Take(1).First();
				drawPile.Remove(output);
				return output;
			}
		}
	}
}
