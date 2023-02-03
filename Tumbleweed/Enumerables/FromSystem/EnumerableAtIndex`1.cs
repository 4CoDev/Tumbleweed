using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Enumerables.FromSystem;

public sealed class EnumerableAtIndex<T> : EnumerableEnvelope<T>
{
	public EnumerableAtIndex
	(
		IEnumerable<IEnumerable<T>> enumerable,
		IScalar<int> index
	) : base
	(
		new EnumerableOfScalar<T>(
			new ScalarAtIndex<IEnumerable<T>>(enumerable, index))
	)
	{
	}
}