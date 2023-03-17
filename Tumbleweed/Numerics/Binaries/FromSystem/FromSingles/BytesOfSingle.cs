using Tumbleweed.Bits;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles;

public sealed class BytesOfSingle : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfSingle(IScalar<Single> @float) : base
	(
		new BytesFromSystem(
			new EnumerableOfFunction<Byte>(
				() => BitConverter.GetBytes(@float.Value)))
	)
	{
	}
}