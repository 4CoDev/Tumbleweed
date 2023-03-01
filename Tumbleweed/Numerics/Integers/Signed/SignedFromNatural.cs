using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedFromNatural : SignedEnvelope
{
	public SignedFromNatural(IEnumerable<IBit> natural) : base
	(
		new SignedWithValues(
			new BitFromBoolean(true),
			natural)
	)
	{
	}
}