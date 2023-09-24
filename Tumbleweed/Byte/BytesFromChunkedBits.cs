using Tumbleweed.Boolean;
using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Boolean;

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