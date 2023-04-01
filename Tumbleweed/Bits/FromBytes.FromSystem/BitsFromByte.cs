using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem;

public sealed class BitsFromByte : EnumerableEnvelope<IBit>
{
	public BitsFromByte(Byte @byte) : this
	(
		new ScalarValue<Byte>(@byte)
	)
	{
	}
	
	public BitsFromByte(IScalar<Byte> @byte) : base
	(
		new EnumerableOfScalar<IBit>(
				new Scalar.BitsFromByte(@byte))
	)
	{
	}
}