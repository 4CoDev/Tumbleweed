using Tumbleweed.Bits;
using Tumbleweed.Bytes.ToSystem;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.ToSystem.Ints32;

public sealed class Int32FromBytes : ScalarEnvelope<int>
{
	public Int32FromBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new OfSystem.Ints32.NumberFromBytes(
			new EnumerableWithSize<byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}