using Tumbleweed.Bits;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Bytes;

public sealed class BytesFromChunkedBits
	: EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new SelectedByExpression<IEnumerable<IBit>>(
			bytes,
			@byte => new ByteFromBits(@byte))
	)
	{
	}
}