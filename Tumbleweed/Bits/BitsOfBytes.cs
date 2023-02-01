using Tumbleweed.Enumerables;

namespace Tumbleweed.Bits;

public sealed class BitsOfBytes : EnumerableEnvelope<IBit>
{
	public BitsOfBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new EnumerableWithElements<IBit>(
			new Bytes.BytesFromChunkedBits(bytes))
	)
	{
	}
}