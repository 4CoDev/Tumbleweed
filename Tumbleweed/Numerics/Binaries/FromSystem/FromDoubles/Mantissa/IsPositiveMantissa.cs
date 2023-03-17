using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class IsPositiveMantissa : BitEnvelope
{
	public IsPositiveMantissa(Double @double) : this
	(
		new ScalarOfValue<Double>(@double)
	)
	{
	}
	
	public IsPositiveMantissa(IScalar<Double> @double) : base
	(
		new LastBit(
			new BitsOfDouble(@double))
	)
	{
	}
}