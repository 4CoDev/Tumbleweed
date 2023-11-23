using Tumbleweed.Collection.Without.Item;
using Enumerable =  Tumbleweed.Enumerable;
using Collection = Tumbleweed.Collection;

namespace Tumbleweed.Enumerable.Without.Item;

public sealed class Last<T> : Enumerable::Envelope<T>
{
	public Last(IEnumerable<T> enumerable) : base
	(
		new Collection.Without.Item.Last<T>(
			new List<T>(enumerable))
	)
	{
	}
}