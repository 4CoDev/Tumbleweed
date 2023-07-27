using Enumerable = Tumbleweed.Enumerable;
using Collection = Tumbleweed.Collection;
using Integer = Tumbleweed.Number.Integer;

namespace Tumbleweed.Enumerable.With.Length.Statement;

public sealed class Tumbleweed<T> : Enumerable::Envelope<T>
{
	public Tumbleweed
	(
		IEnumerable<T> enumerable,
		Integer.Any length
	) : base
	(
		new Collection::CollectionWithSize<T>(
			new List<T>(enumerable),
			length)
	)
	{
	}
}