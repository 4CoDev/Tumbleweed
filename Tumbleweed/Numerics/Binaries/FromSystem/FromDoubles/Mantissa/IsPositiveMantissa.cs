using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles.Mantissa;

public sealed class IsPositiveMantissa : BitEnvelope
{
	public IsPositiveMantissa(double @double) : this
	(
		new ScalarOfValue<double>(@double)
	)
	{
	}
	
	public IsPositiveMantissa(IScalar<double> @double) : base
	(
		new LastBit(
			new BitsOfDouble(@double))
	)
	{
	}
}