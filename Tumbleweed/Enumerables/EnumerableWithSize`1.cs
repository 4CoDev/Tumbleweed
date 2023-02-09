using Tumbleweed.Collections;
using Tumbleweed.Numerics.Integers;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableWithSize<T> : EnumerableEnvelope<T>
{
	public EnumerableWithSize
	(
		IEnumerable<T> enumerable,
		IInteger size
	) : base
	(
		new CollectionWithSize<T>(new List<T>(enumerable), size)
	)
	{
	}
}