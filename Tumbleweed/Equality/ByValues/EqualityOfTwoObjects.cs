using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Bits.OfSystem;

namespace Tumbleweed.Equality.ByValues;

public sealed class EqualityOfTwoObjects : BitEnvelope
{
	public EqualityOfTwoObjects
	(
		Object first,
		Object second
	) : base
	(
		new BitFromBoolean(
			new BooleanOfFunction(
				() => first.Equals(second)))
	)
	{
	}
}