using Tumbleweed.Byte;
using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Boolean;

public sealed class BitsOfBytes : Envelope<Any>
{
	public BitsOfBytes(IEnumerable<IEnumerable<Any>> bytes) : base
	(
		new Concatenated<Any>(
			new BytesFromChunkedBits(bytes))
	)
	{
	}
}