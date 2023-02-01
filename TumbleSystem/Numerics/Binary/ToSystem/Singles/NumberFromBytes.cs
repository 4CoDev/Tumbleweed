using TumbleSystem.Bytes.ToSystem;
using TumbleSystem.Enumerables;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Binary.ToSystem.Singles;

public sealed class NumberFromBytes : ScalarEnvelope<float>
{
	public NumberFromBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new OfSystem.Singles.NumberFromBytes(
			new EnumerableWithSize<byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}