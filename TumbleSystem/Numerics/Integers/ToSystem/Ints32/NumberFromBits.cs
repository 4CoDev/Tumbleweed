using TumbleSystem.Bytes;
using TumbleSystem.Enumerables;
using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Integers.ToSystem.Ints32;

public sealed class NumberFromBits : ScalarEnvelope<int>
{
	public NumberFromBits(IEnumerable<IBit> bits) : base
	(
		new NumberFromBytes(
			new BytesFromBits(
				new EnumerableWithSize<IBit>(bits, 32)))
	)
	{
	}
}