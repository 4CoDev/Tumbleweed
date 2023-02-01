using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bits.FromBytes.FromSystem;

public sealed class BitsFromByte : EnumerableEnvelope<IBit>
{
	public BitsFromByte(IScalar<byte> @byte) : base
	(
		new EnumerableOfScalar<IBit>(
				new Scalar.BitsFromByte(@byte))
	)
	{
	}
}