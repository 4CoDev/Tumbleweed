using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromBytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;

namespace Tumbleweed.Bytes;

public sealed class BytesFromBits : EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesFromBits(IEnumerable<IBoolean> bits) : base
	(
		new BytesFromChunkedBits(
			new ChunkedBySize<IBoolean>(bits, new NumberOfBits()))
	)
	{
	}
}