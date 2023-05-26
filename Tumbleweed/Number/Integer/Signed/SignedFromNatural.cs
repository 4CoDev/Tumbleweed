using Tumbleweed._Boolean.FromSystem;
using Tumbleweed.Number.Integer.Natural;

namespace Tumbleweed.Number.Integer.Signed;

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