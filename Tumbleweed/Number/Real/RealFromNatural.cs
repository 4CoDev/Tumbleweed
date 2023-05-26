using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.ToSystem;
using Tumbleweed.Number.Real.Binary.OfSystem.Singles;
using Tumbleweed.Number.Real.FromSystem;

namespace Tumbleweed.Number.Real;

public sealed class RealFromNatural : RealEnvelope
{
	public RealFromNatural(INatural natural) : base
	(
		new RealFromSingle(
			new SingleFromInt32(
				new Int32FromNatural(natural)))
	)
	{
	}
}