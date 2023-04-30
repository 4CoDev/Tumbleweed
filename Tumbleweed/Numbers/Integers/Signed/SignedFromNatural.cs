using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Numbers.Integers.Natural;

namespace Tumbleweed.Numbers.Integers.Signed;

public sealed class SignedFromNatural : SignedEnvelope
{
	public SignedFromNatural(INatural natural) : base
	(
		new SignedWithValues(
			new BooleanFromSystem(true),
			natural)
	)
	{
	}
}