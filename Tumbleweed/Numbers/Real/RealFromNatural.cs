using Tumbleweed.Numbers.Integers.Natural.ToSystem;
using Tumbleweed.Numbers.Real.Binaries.OfSystem.Singles;

namespace Tumbleweed.Numbers.Real;

using Integers.Natural;
using FromSystem;

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