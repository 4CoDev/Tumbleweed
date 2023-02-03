using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class ElementsFromMiddle<T> : EnumerableEnvelope<T>
{
	public ElementsFromMiddle
	(
		IEnumerable<T> collection,
		int from,
		int to
	) : this
	(
		collection,
		new ScalarOfValue<int>(from),
		new ScalarOfValue<int>(to)
	)
	{
	}
	
	public ElementsFromMiddle
	(
		IEnumerable<T> collection,
		IScalar<int> from,
		IScalar<int> to
	) : base
	(
		new EnumerableOfDelegate<T>(
			() => collection
				.Skip(from.Value())
				.Take(to.Value() - from.Value() + 1))
	)
	{
	}
}