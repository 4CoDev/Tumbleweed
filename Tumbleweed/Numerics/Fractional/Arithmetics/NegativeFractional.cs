using Tumbleweed.Numerics.Fractional.Binaries.Singles.Arithmetics;
using Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional.FromSystem;

namespace Tumbleweed.Numerics.Fractional.Arithmetics;

public sealed class NegativeFractional : FractionalEnvelope
{
	public NegativeFractional(IFractional fractional) : base
	(
		new FractionalFromSingle(
			new NegativeSingle(
				new SingleFromFractional(fractional)))
	)
	{
	}
}