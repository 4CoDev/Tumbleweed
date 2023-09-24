using Tumbleweed.Boolean;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Item.Every.Scalar;
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Byte.ToSystem;

public sealed class BytesFromChunkedBits : Enumerable.Envelope<System.Byte>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<Any>> bytes) : base
	(
		new Value<System.Byte>(
			new Selected<IEnumerable<Any>, Any<System.Byte>>(
				bytes,
				@byte => new ByteFromBits(@byte)))
	)
	{
	}
}