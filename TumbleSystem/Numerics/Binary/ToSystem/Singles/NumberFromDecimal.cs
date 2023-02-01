using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Binary.ToSystem.Singles;

public sealed class NumberFromDecimal : ScalarEnvelope<float>
{
	public NumberFromDecimal(IDecimal @decimal) : base
	(
		new NumberFromBits(
			new EnumerableWithElements<IBit>(
				@decimal.Mantissa.Natural,
				@decimal.Exponent.Natural,
				new EnumerableWithElements<IBit>(
					@decimal.Exponent.Positive,
					@decimal.Mantissa.Positive)))
	)
	{
	}

}