using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.ToSystem.Ints32;

namespace Tumbleweed.Collections;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize(ICollection<T> collection, IInteger size) : base
	(
		new FromSystem.CollectionWithSize<T>(
			collection,
			new Int32FromInteger(size))
	)
	{
	}
}