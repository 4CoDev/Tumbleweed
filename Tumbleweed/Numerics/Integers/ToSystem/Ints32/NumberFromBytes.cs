using Tumbleweed.Bits;
using Tumbleweed.Bytes.ToSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.ToSystem.Ints32;

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