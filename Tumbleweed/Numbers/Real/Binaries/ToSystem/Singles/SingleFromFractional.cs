using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;

public sealed class SingleFromFractional : ScalarEnvelope<Single>
{
	public SingleFromFractional(IReal real) : base
	(
		new SingleFromBits(
			new EnumerableWithElements<IBoolean>(
				real.Mantissa.Natural.Bits,
				real.Exponent.Natural.Bits,
				new EnumerableWithElements<IBoolean>(
					real.Exponent.IsPositive,
					real.Mantissa.IsPositive)))
	)
	{
	}

}