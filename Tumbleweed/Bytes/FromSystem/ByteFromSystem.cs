using Tumbleweed.Bits;
using Tumbleweed.Bits.FromBytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.FromSystem;

public sealed class ByteFromSystem : EnumerableEnvelope<IBit>
{
	public ByteFromSystem(IScalar<Byte> @byte) : base
	(
		new EnumerableOfFunction<IBit>(
			() => Function(@byte))
	)
	{
	}

	private static IEnumerable<IBit> Function(IScalar<Byte> @byte)
	{
		for (Int32 index = 0; index < 8; index++)
			yield return new BitWithIndex(@byte, index);
	}
}