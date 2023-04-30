using Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Arithmetics;

public sealed class NegativeReal : RealEnvelope
{
	public NegativeReal(IReal real) : base
	(
		new RealFromSingle(
			new NegativeSingle(
				new SingleFromFractional(real)))
	)
	{
	}
}