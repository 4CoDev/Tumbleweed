using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Equality.ByReference;

public sealed class EqualityOfTwoObjects : BitEnvelope
{
	public EqualityOfTwoObjects
	(
		Object first,
		Object second
	) : base
	(
		new EqualityOfTwoNullables(first, second)
	)
	{
	}
}