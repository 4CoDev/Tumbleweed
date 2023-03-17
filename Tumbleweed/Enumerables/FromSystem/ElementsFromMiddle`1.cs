using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class ElementsFromMiddle<T> : EnumerableEnvelope<T>
{
	public ElementsFromMiddle
	(
		IEnumerable<T> collection,
		Int32 from,
		Int32 to
	) : this
	(
		collection,
		new ScalarOfValue<Int32>(from),
		new ScalarOfValue<Int32>(to)
	)
	{
	}
	
	public ElementsFromMiddle
	(
		IEnumerable<T> collection,
		IScalar<Int32> from,
		IScalar<Int32> to
	) : base
	(
		new EnumerableOfFunction<T>(
			() => collection
				.Skip(from.Value)
				.Take(to.Value - from.Value + 1))
	)
	{
	}
}