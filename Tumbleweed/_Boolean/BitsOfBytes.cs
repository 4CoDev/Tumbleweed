using Tumbleweed._Byte;
using Tumbleweed._Enumerable;

namespace Tumbleweed._Boolean;

public sealed class BitsOfBytes : EnumerableEnvelope<IBoolean>
{
	public BitsOfBytes(IEnumerable<IEnumerable<IBoolean>> bytes) : base
	(
		new EnumerableWithElements<IBoolean>(
			new BytesFromChunkedBits(bytes))
	)
	{
	}
}