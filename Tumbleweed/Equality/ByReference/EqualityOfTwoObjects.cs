using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Equality.ByReference;

public sealed class EqualityOfTwoObjects : BitEnvelope
{
	public EqualityOfTwoObjects
	(
		object first,
		object second
	) : base
	(
		new TwoNullableObjects(first, second)
	)
	{
	}
}