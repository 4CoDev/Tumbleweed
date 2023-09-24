using Tumbleweed.Mathematics.Number.Integer;
using Enumerable = Tumbleweed.Enumerable;
using Collection = Tumbleweed.Collection;
using Integer = Tumbleweed.Mathematics.Number.Integer;

namespace Tumbleweed.Enumerable.With.Length.Statement;

public sealed class Tumbleweed<T> : Enumerable::Envelope<T>
{
	public Tumbleweed
	(
		IEnumerable<T> enumerable,
		Any length
	) : base
	(
		new Collection::CollectionWithSize<T>(
			new List<T>(enumerable),
			length)
	)
	{
	}
}