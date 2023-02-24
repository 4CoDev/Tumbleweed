using Tumbleweed.Bits;

namespace Tumbleweed.Equality.ByValues;

public sealed class EqualityOfTwoObjects : BitEnvelope
{
	public EqualityOfTwoObjects
	(
		object first,
		object second
	) : base
	(
		new EqualityOfTwoNullables(first, second)
	)
	{
	}
}