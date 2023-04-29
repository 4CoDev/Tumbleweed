using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Booleans.FromBytes.FromSystem;

public sealed class BitsFromBytes : EnumerableEnvelope<IBoolean>
{
	public BitsFromBytes(IEnumerable<Byte> bytes) : this
	(
		new ScalarsOfValues<Byte>(bytes)
	)
	{
	}
	
	public BitsFromBytes(IEnumerable<IScalar<Byte>> bytes) : base
	(
		new EnumerableWithElements<IBoolean>(
			new SelectedByExpression<IScalar<Byte>, IEnumerable<IBoolean>>(
				bytes,
				@byte => new BitsFromByte(@byte)))
	)
	{
	}
}