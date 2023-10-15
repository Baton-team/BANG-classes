namespace BANG-classes;

public class Desk : ICardPile
{
	public List<Card> Cards { get; }

	public Desk()
	{
		Cards = new List<Card>();
	}

	public void AddCard(Card card)
	{
		Cards.Add(card);
	}
}