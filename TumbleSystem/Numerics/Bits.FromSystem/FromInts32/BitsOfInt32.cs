using TumbleSystem.Numerics.Bytes.FromSystem;
using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bits.FromSystem.FromInts32;

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