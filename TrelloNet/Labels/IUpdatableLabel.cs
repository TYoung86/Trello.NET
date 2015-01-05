namespace TrelloNet
{
	public interface IUpdatableLabel
	{
		string Id { get; }
		string Name { get; }
		Color Color { get; }
	}
}