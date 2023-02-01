using TumbleSystem.Numerics.Bytes.FromSystem;
using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Bits.FromSystem.FromSingles;

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