using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bytes.FromSystem;

public sealed class ByteFromSystem : EnumerableEnvelope<IBit>
{
	public ByteFromSystem(IScalar<byte> @byte) : base
	(
		new EnumerableOfScalar<IBit>(
			new Scalar.Byte(@byte))
	)
	{
	}
}