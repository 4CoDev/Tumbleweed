using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.ToSystem.Singles;

public sealed class SingleFromFractional : ScalarEnvelope<float>
{
	public SingleFromFractional(IFractional fractional) : base
	(
		new SingleFromBits(
			new EnumerableWithElements<IBit>(
				fractional.Mantissa.Number,
				fractional.Exponent.Number,
				new EnumerableWithElements<IBit>(
					fractional.Exponent.Positive,
					fractional.Mantissa.Positive)))
	)
	{
	}

}