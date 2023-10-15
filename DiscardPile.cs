namespace BANG-classes;

public class DiscardPile : ICardPile
{
	public List<Card> Cards { get; }

	public DiscardPile()
	{
		Cards = new List<Card>();
	}

	public void AddCard(Card card)
	{
		Cards.Add(card);
	}
}