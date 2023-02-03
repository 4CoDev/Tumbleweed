using Tumbleweed.Collections;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableWithSize<T> : EnumerableEnvelope<T>
{
	public EnumerableWithSize(IEnumerable<T> enumerable, int size) : this
	(
		enumerable, new ScalarOfValue<int>(size)
	)
	{
	}
	
	public EnumerableWithSize
	(
		IEnumerable<T> enumerable,
		IScalar<int> size
	) : base
	(
		new CollectionWithSize<T>(new List<T>(enumerable), size)
	)
	{
	}
}