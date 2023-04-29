using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedFromNatural : SignedEnvelope
{
	public SignedFromNatural(INaturalInteger natural) : base
	(
		new SignedWithValues(
			new BooleanFromSystem(true),
			natural)
	)
	{
	}
}