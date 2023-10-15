namespace BANG_classes.Interfaces
{
	internal interface ICardPile
	{
		List<ICard> Cards { get; }

		void Shuffle();
	}
}