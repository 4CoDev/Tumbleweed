using Tumbleweed.Bits;
using Tumbleweed.Bits.FromEnumerable;
using Tumbleweed.Bits.WithSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem;

public sealed class IsPositiveInt32 : BitEnvelope
{
	public IsPositiveInt32(IScalar<int> integer) : base
	(
		new LastBit(new BitsOfInt32(integer))
	)
	{
	}
}