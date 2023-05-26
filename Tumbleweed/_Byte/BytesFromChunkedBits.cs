using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;

namespace Tumbleweed._Byte;

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