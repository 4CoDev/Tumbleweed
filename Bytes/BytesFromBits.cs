using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes;

public sealed class BytesFromBits : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesFromBits(IEnumerable<IBit> bits) : this
	(
		new ChunkedBySize<IBit>(bits, new ScalarOfValue<int>(8))
	)
	{
	}
	
	public BytesFromBits(IEnumerable<IEnumerable<IBit>> chunks) : base
	(
		new SelectedByExpression<IEnumerable<IBit>>(
			chunks,
			bits => new ByteFromBits(bits))
	)
	{
	}
}