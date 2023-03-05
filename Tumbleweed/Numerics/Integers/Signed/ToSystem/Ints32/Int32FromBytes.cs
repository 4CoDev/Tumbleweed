using Tumbleweed.Bits;
using Tumbleweed.Bytes.ToSystem;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromBytes : ScalarEnvelope<Int32>
{
	public Int32FromBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new OfSystem.Ints32.Int32FromBytes(
			new EnumerableWithSize<Byte>(
				new BytesFromChunkedBits(bytes),
				4))
	)
	{
	}
}