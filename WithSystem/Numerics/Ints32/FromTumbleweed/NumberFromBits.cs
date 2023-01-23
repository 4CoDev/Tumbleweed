using Tumbleweed.Bits;
using Tumbleweed.Bytes;
using Tumbleweed.Scalars;

namespace Tumbleweed.WithSystem.Numerics.Ints32.FromTumbleweed;

public sealed class NumberFromBits : ScalarEnvelope<int>
{
	public NumberFromBits(IEnumerable<IBit> bits) : base
	(
		new NumberFromBytes(
			new BytesFromBits(bits))
	)
	{
	}
}