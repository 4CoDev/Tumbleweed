using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class TakedEnumerable<T> : EnumerableEnvelope<T>
{
	public TakedEnumerable
	(
		IEnumerable<T> enumerable,
		IScalar<Int32> elements
	) : base
	(
		new EnumerableOfScalar<T>(
			new ValueOfDelegate<IEnumerable<T>>(
				() => enumerable.Take(elements.Value)))
	)
	{
	}
}