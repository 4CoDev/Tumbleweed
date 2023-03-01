using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

namespace Tumbleweed.Collections;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize(ICollection<T> collection, ISignedInteger size) : base
	(
		new FromSystem.CollectionWithSize<T>(
			collection,
			new Int32FromSigned(size))
	)
	{
	}
}