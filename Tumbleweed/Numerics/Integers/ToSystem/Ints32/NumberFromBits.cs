using Tumbleweed.Bits;
using Tumbleweed.Bytes;
using Tumbleweed.Enumerables;
using Tumbleweed.Enumerables.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.ToSystem.Ints32;

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