using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.ToSystem;

public sealed class BytesFromChunkedBits : EnumerableEnvelope<Byte>
{
	public BytesFromChunkedBits(IEnumerable<IEnumerable<IBoolean>> bytes) : base
	(
		new ValuesOfScalars<Byte>(
			new SelectedByExpression<IEnumerable<IBoolean>, IScalar<Byte>>(
				bytes,
				@byte => new ByteFromBits(@byte)))
	)
	{
	}
}