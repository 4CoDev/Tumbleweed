using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Booleans.FromBytes.FromSystem;

public sealed class BitsFromByte : EnumerableEnvelope<IBoolean>
{
	public BitsFromByte(Byte @byte) : this
	(
		new ScalarValue<Byte>(@byte)
	)
	{
	}
	
	public BitsFromByte(IScalar<Byte> @byte) : base
	(
		new EnumerableOfScalar<IBoolean>(
				new Scalar.BitsFromByte(@byte))
	)
	{
	}
}