using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromBytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.FromSystem;

public sealed class ByteFromSystem : EnumerableEnvelope<IBoolean>
{
	public ByteFromSystem(IScalar<Byte> @byte) : base
	(
		new EnumerableOfFunction<IBoolean>(
			() => Function(@byte))
	)
	{
	}

	private static IEnumerable<IBoolean> Function(IScalar<Byte> @byte)
	{
		for (Int32 index = 0; index < 8; index++)
			yield return new BooleanWithIndex(@byte, index);
	}
}