using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem;

public sealed class BitsFromBytes : EnumerableEnvelope<IBit>
{
	public BitsFromBytes(IEnumerable<byte> bytes) : this
	(
		new ScalarsOfValues<byte>(bytes)
	)
	{
	}
	
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