using Tumbleweed.Number.Real.Binary.Singles.Arithmetics.Rounding;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Arithmetic.Rounding;

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