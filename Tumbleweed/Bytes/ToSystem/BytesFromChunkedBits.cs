using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.ToSystem;

public sealed class BytesFromChunkedBits : EnumerableEnvelope<byte>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new ValuesOfScalars<byte>(
			new SelectedByExpression<IEnumerable<IBit>, IScalar<byte>>(
				bytes,
				@byte => new ByteFromBits(@byte)))
	)
	{
	}
}