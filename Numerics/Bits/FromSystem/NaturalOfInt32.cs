using Tumbleweed.Bits;
using Tumbleweed.Bits.WithSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem;

public sealed class NaturalOfInt32 : EnumerableEnvelope<IBit>
{
	public NaturalOfInt32(IScalar<int> integer) : base
	(
		new WithoutLastElement<IBit>(new BitsOfInt32(integer))
	)
	{
	}
}