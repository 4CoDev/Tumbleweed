using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.WithSystem.FromBytes;

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