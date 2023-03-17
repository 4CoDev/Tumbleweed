using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class IsPositiveMantissa : BitEnvelope
{
	public IsPositiveMantissa(IScalar<Single> @float) : base
	(
		new LastBit(new BitsOfSingle(@float))
	)
	{
	}
}