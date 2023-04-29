using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.ToSystem.Singles;

public sealed class SingleFromFractional : ScalarEnvelope<Single>
{
	public SingleFromFractional(IFractional fractional) : base
	(
		new SingleFromBits(
			new EnumerableWithElements<IBoolean>(
				fractional.Mantissa.Natural.Bits,
				fractional.Exponent.Natural.Bits,
				new EnumerableWithElements<IBoolean>(
					fractional.Exponent.Positive,
					fractional.Mantissa.Positive)))
	)
	{
	}

}