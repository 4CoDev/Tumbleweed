using TumbleSystem.Bytes.ToSystem;
using TumbleSystem.Enumerables;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Integers.ToSystem.Ints32;

public sealed class NumberFromBytes : ScalarEnvelope<int>
{
	public NumberFromBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new OfSystem.Ints32.NumberFromBytes(
			new EnumerableWithSize<byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}