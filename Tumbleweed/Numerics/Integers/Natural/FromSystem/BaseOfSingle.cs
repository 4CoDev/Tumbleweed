using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Bits.FromSystem.FromInts32;

namespace Tumbleweed.Numerics.Integers.Natural.FromSystem;

public sealed class BaseOfSingle : EnumerableEnvelope<IBit>
{
	public BaseOfSingle() : base
	(
		new NaturalOfInt32(2)
	)
	{
	}
}