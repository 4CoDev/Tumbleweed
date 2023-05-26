using Tumbleweed.Number.Integer.Natural.FromSystem;
using Tumbleweed.Number.Integer.Natural.OfSystem;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.ToSystem.Singles;

namespace Tumbleweed.Number.Integer.Natural;

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