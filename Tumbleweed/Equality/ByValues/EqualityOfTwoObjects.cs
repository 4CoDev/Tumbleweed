using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Bits.OfSystem;

namespace Tumbleweed.Equality.ByValues;

public sealed class EqualityOfTwoObjects : BitEnvelope
{
	public EqualityOfTwoObjects
	(
		object first,
		object second
	) : base
	(
		new BitFromBoolean(
			new BooleanOfDelegate(
				() => first.Equals(second)))
	)
	{
	}
}