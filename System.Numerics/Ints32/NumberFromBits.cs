using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace Tumbleweed.System.Numerics.Ints32;

public sealed class NumberFromBits : ScalarEnvelope<int>
{
	public NumberFromBits(IEnumerable<IBit> bits) : base
	(
		new ScalarOfValue<int>(1337)
	)
	{
	}
}