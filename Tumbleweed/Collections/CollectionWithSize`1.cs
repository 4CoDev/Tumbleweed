using Tumbleweed.Numbers.Integers.Signed;
using Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;

namespace Tumbleweed.Collections;

public sealed class CollectionWithSize<T> : CollectionEnvelope<T>
{
	public CollectionWithSize
	(
		ICollection<T> collection,
		ISigned size
	) : base
	(
		new FromSystem.CollectionWithSize<T>(
			collection,
			new Int32FromSigned(size))
	)
	{
	}
}