using Tumbleweed.Collections;
using Tumbleweed.Numbers.Integers.Signed;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableWithSize<T> : EnumerableEnvelope<T>
{
	public EnumerableWithSize
	(
		IEnumerable<T> enumerable,
		ISigned size
	) : base
	(
		new CollectionWithSize<T>(new List<T>(enumerable), size)
	)
	{
	}
}