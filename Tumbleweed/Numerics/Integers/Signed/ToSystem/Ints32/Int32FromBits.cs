using Tumbleweed.Bits;
using Tumbleweed.Bytes;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromBits : ScalarEnvelope<int>
{
	public Int32FromBits(IEnumerable<IBit> bits) : base
	(
		new Int32FromBytes(
			new BytesFromBits(
				new EnumerableWithSize<IBit>(bits, 32)))
	)
	{
	}
}