using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bytes.FromSystem;

public sealed class BytesOfSingle : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfSingle(IScalar<float> @float) : base
	(
		new TumbleSystem.Bytes.FromSystem.BytesFromSystem(
			new EnumerableOfDelegate<byte>(
				() => BitConverter.GetBytes(@float.Value())))
	)
	{
	}
}