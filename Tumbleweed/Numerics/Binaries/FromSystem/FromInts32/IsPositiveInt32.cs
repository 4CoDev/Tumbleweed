using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromInts32;

public sealed class IsPositiveInt32 : BitEnvelope
{
	public IsPositiveInt32(IScalar<Int32> integer) : base
	(
		new LastBit(new BitsOfInt32(integer))
	)
	{
	}
}