using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.WithSystem;

public sealed class BytesFromTumbleweed : EnumerableEnvelope<IScalar<byte>>
{
	public BytesFromTumbleweed(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new SelectedByExpression<IEnumerable<IBit>, IScalar<byte>>
		(
			bytes,
			@byte => new ByteFromTumbleweed(@byte)
		)
	)
	{
	}
}