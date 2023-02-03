using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromBytes.FromSystem;

public sealed class BitsFromByte : EnumerableEnvelope<IBit>
{
	public BitsFromByte(byte @byte) : this
	(
		new ScalarOfValue<byte>(@byte)
	)
	{
	}
	
	public BitsFromByte(IScalar<byte> @byte) : base
	(
		new EnumerableOfScalar<IBit>(
				new Scalar.BitsFromByte(@byte))
	)
	{
	}
}