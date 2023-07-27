using Tumbleweed.Boolean;
using Tumbleweed.Enumerable;

namespace Tumbleweed.Byte;

public sealed class BytesFromChunkedBits
	: Envelope<IEnumerable<Any>>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<Any>> bytes) : base
	(
		new Selected<IEnumerable<Any>>(
			bytes,
			@byte => new ByteFromBits(@byte))
	)
	{
	}
}