using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.FromSystem;

public sealed class ByteFromSystem : EnumerableEnvelope<IBit>
{
	public ByteFromSystem(IScalar<Byte> @byte) : base
	(
		new EnumerableOfScalar<IBit>(
			new Scalar.Byte(@byte))
	)
	{
	}
}