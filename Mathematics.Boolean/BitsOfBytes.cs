using Tumbleweed.Enumerable;
using Tumbleweed.Information.Measurement.Byte.Multiple.From.Bit.Enumerable;

namespace Tumbleweed.Mathematics.Boolean;

public sealed class BitsOfBytes : Envelope<Any>
{
	public BitsOfBytes(IEnumerable<IEnumerable<Any>> bytes) : base
	(
		new Concatenated<Any>(
			new Chunked(bytes))
	)
	{
	}
}