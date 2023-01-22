using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.WithSystem.FromBytes;

public sealed class BitsFromBytes : EnumerableEnvelope<IBit>
{
	public BitsFromBytes(IEnumerable<IScalar<byte>> bytes) : base
	(
		new EnumerableWithElements<IBit>(
			new SelectedByExpression<IScalar<byte>, IEnumerable<IBit>>(
				bytes,
				@byte => new BitsFromByte(@byte)))
	)
	{
	}
}