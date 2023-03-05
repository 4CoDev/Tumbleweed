using Tumbleweed.Bits;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles;

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