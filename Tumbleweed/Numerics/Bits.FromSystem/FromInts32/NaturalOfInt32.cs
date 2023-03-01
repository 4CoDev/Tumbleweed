using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromInts32;

public sealed class NaturalOfInt32 : EnumerableEnvelope<IBit>
{
	public NaturalOfInt32(int integer) : this
	(
		new ScalarOfValue<int>(integer)
	)
	{
	}
	
	public NaturalOfInt32(IScalar<int> integer) : base
	(
		new WithoutLastElement<IBit>(
			new BitsOfInt32(integer))
	)
	{
	}
}