using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromInts32;

public sealed class NaturalOfInt32 : EnumerableEnvelope<IBit>
{
	public NaturalOfInt32(Int32 integer) : this
	(
		new ScalarValue<Int32>(integer)
	)
	{
	}
	
	public NaturalOfInt32(IScalar<Int32> integer) : base
	(
		new WithoutLastElement<IBit>(
			new BitsOfInt32(integer))
	)
	{
	}
}