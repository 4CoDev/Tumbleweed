using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;

namespace Tumbleweed.Bytes;

public sealed class BytesFromChunkedBits
	: EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<IBoolean>> bytes) : base
	(
		new SelectedByExpression<IEnumerable<IBoolean>>(
			bytes,
			@byte => new ByteFromBits(@byte))
	)
	{
	}
}