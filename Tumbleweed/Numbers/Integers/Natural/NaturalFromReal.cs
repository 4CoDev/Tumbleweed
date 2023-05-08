using Tumbleweed.Numbers.Integers.Natural.FromSystem;
using Tumbleweed.Numbers.Integers.Natural.OfSystem;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

namespace Tumbleweed.Numbers.Integers.Natural;

public sealed class NaturalFromReal : NaturalEnvelope
{
	public NaturalFromReal(IReal real) : base
	(
		new NaturalFromInt32(
			new Int32FromSingle(
				new SingleFromReal(real)))
	)
	{
	}
}