namespace Tumbleweed.Number.Integer.Signed.FromSystem;

public sealed class BaseOfDouble : SignedEnvelope
{
	public BaseOfDouble() : base
	(
		new SignedFromNatural(
			new Natural.FromSystem.BaseOfDouble())
	)
	{
	}
}