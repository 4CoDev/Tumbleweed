using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem;

public sealed class BitsFromBytes : EnumerableEnvelope<IBit>
{
	public BitsFromBytes(IEnumerable<Byte> bytes) : this
	(
		new ScalarsOfValues<Byte>(bytes)
	)
	{
	}
	
	public BitsFromBytes(IEnumerable<IScalar<Byte>> bytes) : base
	(
		new EnumerableWithElements<IBit>(
			new SelectedByExpression<IScalar<Byte>, IEnumerable<IBit>>(
				bytes,
				@byte => new BitsFromByte(@byte)))
	)
	{
	}
}