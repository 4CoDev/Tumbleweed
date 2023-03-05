using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromInts32;

public sealed class BitsOfInt32 : EnumerableEnvelope<IBit>
{
	public BitsOfInt32(IScalar<int> integer) : base
	(
		new BitsOfBytes(
			new BytesOfInt32(integer))
	)
	{
	}
}