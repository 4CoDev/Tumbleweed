using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binary.ToSystem.Singles;

public sealed class SingleFromDecimal : ScalarEnvelope<float>
{
	public SingleFromDecimal(IDecimal @decimal) : base
	(
		new SingleFromBits(
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