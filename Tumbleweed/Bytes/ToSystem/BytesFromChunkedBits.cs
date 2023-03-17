using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.ToSystem;

public sealed class BytesFromChunkedBits : EnumerableEnvelope<Byte>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new ValuesOfScalars<Byte>(
			new SelectedByExpression<IEnumerable<IBit>, IScalar<Byte>>(
				bytes,
				@byte => new ByteFromBits(@byte)))
	)
	{
	}
}