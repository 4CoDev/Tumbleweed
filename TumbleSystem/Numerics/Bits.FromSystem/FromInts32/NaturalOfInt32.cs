using TumbleSystem.Enumerables;
using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bits.FromSystem.FromInts32;

public sealed class NaturalOfInt32 : EnumerableEnvelope<IBit>
{
	public NaturalOfInt32(IScalar<int> integer) : base
	(
		new WithoutLastElement<IBit>(new BitsOfInt32(integer))
	)
	{
	}
}