using Tumbleweed.Bits;
using Tumbleweed.Bits.FromBytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;

namespace Tumbleweed.Bytes;

public sealed class BytesFromBits : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesFromBits(IEnumerable<IBit> bits) : base
	(
		new BytesFromChunkedBits(
			new ChunkedBySize<IBit>(bits, new NumberOfBits()))
	)
	{
	}
}