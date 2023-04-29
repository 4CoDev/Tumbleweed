using Tumbleweed.Enumerables;

namespace Tumbleweed.Booleans;

public sealed class BitsOfBytes : EnumerableEnvelope<IBoolean>
{
	public BitsOfBytes(IEnumerable<IEnumerable<IBoolean>> bytes) : base
	(
		new EnumerableWithElements<IBoolean>(
			new Bytes.BytesFromChunkedBits(bytes))
	)
	{
	}
}