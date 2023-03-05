using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.ToSystem.Singles;

public sealed class SingleFromFractional : ScalarEnvelope<Single>
{
	public SingleFromFractional(IFractional fractional) : base
	(
		new SingleFromBits(
			new EnumerableWithElements<IBit>(
				fractional.Mantissa.Natural.Bits,
				fractional.Exponent.Natural.Bits,
				new EnumerableWithElements<IBit>(
					fractional.Exponent.Positive,
					fractional.Mantissa.Positive)))
	)
	{
	}

}