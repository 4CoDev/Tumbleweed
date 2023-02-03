using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Bytes.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bits.FromSystem.FromSingles;

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