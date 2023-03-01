using Tumbleweed.Collections;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableWithSize<T> : EnumerableEnvelope<T>
{
	public EnumerableWithSize
	(
		IEnumerable<T> enumerable,
		ISignedInteger size
	) : base
	(
		new CollectionWithSize<T>(new List<T>(enumerable), size)
	)
	{
	}
}