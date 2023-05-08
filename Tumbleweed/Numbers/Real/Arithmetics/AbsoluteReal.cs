using Tumbleweed.Numbers.Real.Binaries.Singles.Arithmetics;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Real.FromSystem;

namespace Tumbleweed.Numbers.Real.Arithmetics;

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