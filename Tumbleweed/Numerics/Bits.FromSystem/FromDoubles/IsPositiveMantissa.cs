using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromDoubles;

public sealed class IsPositiveMantissa : BitEnvelope
{
	public IsPositiveMantissa(IScalar<double> @double) : base
	(
		new LastBit(
			new BitsOfDouble(@double))
	)
	{
	}
}