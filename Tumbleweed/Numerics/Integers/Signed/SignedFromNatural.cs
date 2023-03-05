using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedFromNatural : SignedEnvelope
{
	public SignedFromNatural(INaturalInteger natural) : base
	(
		new SignedWithValues(
			new BitFromBoolean(true),
			natural)
	)
	{
	}
}