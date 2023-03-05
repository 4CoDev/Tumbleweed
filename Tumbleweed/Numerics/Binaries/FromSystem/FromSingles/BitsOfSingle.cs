using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromSingles;

public sealed class BitsOfSingle : EnumerableEnvelope<IBit>
{
	public BitsOfSingle(IScalar<float> @float) : base
	(
		new BitsOfBytes(
			new BytesOfSingle(@float))
	)
	{
	}
}