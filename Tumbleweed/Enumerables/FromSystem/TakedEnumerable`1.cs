using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class TakedEnumerable<T> : EnumerableEnvelope<T>
{
	public TakedEnumerable
	(
		IEnumerable<T> enumerable,
		IScalar<int> elements
	) : base
	(
		new EnumerableOfScalar<T>(
			new ScalarOfDelegate<IEnumerable<T>>(
				() => enumerable.Take(elements.Value())))
	)
	{
	}
}