namespace Tumbleweed.Numbers.Integers.Signed.FromSystem;

public sealed class BaseOfSingle : SignedEnvelope
{
	public BaseOfSingle() : base
	(
		new SignedFromNatural(
			new Natural.FromSystem.BaseOfSingle())
	)
	{
	}
}