using Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics.Rounding;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Arithmetics.Rounding;

public sealed class NearestIntegerOfReal : RealEnvelope
{
	public NearestIntegerOfReal(IReal real) : base
	(
		new RealFromSingle(
			new NearestIntegerOfSingle(
				new SingleFromReal(real)))
	)
	{
	}
}