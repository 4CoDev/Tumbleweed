using Tumbleweed.Boolean;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Chunked.By.Length;
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.FromByte.FromSystem;

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