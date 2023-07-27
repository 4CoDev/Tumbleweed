using Tumbleweed.Boolean;
using Tumbleweed.Boolean.FromByte.FromSystem;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Chunked.By.Length;

namespace Tumbleweed.Byte;

public sealed class BytesFromBits : Envelope<IEnumerable<Any>>
{
	public BytesFromBits(IEnumerable<Any> bits) : base
	(
		new BytesFromChunkedBits(
			new System<Any>(bits, new NumberOfBits()))
	)
	{
	}
}