using TumbleSystem.Bits.FromBytes.FromSystem;
using TumbleSystem.Enumerables;
using Tumbleweed.Bits;
using Tumbleweed.Bytes;
using Tumbleweed.Enumerables;

namespace TumbleSystem.Bytes;

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