using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bytes.FromSystem;

public sealed class BytesOfInt32 : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfInt32(IScalar<int> integer) : base
	(
		new TumbleSystem.Bytes.FromSystem.BytesFromSystem(
			new EnumerableOfDelegate<byte>(
				() => BitConverter.GetBytes(integer.Value())))
	)
	{
	}
}