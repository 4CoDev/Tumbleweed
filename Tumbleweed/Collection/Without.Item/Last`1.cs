using Tumbleweed.Enumerable.Function;

namespace Tumbleweed.Collection.Without.Item;

public sealed class Last<T> : Enumerable.Envelope<T>
{
	public Last(ICollection<T> collection) : base
	(
		new Result<T>(
			() => new List<T>(
				collection.Take(
					collection.Count - 1)))
	)
	{
	}
}