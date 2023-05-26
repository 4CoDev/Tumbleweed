using Tumbleweed.Number.Real.Binary.Singles.Arithmetics;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real.Arithmetic;

public sealed class AbsoluteReal : RealEnvelope
{
	public AbsoluteReal(IReal real) : base
	(
		new RealFromSingle(
			new AbsoluteSingle(
				new SingleFromReal(real)))
	)
	{
	}
}