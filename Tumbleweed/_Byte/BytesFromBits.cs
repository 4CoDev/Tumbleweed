using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromByte.FromSystem;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromSystem;

namespace Tumbleweed._Byte;

public sealed class BytesFromBits : EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesFromBits(IEnumerable<IBoolean> bits) : base
	(
		new BytesFromChunkedBits(
			new ChunkedBySize<IBoolean>(bits, new NumberOfBits()))
	)
	{
	}
}