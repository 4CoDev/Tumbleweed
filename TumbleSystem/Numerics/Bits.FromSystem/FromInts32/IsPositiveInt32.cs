using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bits.FromSystem.FromInts32;

public sealed class IsPositiveInt32 : BitEnvelope
{
	public IsPositiveInt32(IScalar<int> integer) : base
	(
		new LastBit(new BitsOfInt32(integer))
	)
	{
	}
}