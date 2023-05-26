using Tumbleweed.Number.Real.Binary.Singles.Arithmetics;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class NegativeReal : RealEnvelope
{
	public NegativeReal(IReal real) : base
	(
		new RealFromSingle(
			new NegativeSingle(
				new SingleFromReal(real)))
	)
	{
	}
}