using Tumbleweed.Bits;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bytes.FromSystem;

public sealed class BytesOfSingle : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfSingle(IScalar<float> @float) : base
	(
		new BytesFromSystem(
			new EnumerableOfDelegate<byte>(
				() => BitConverter.GetBytes(@float.Value)))
	)
	{
	}
}