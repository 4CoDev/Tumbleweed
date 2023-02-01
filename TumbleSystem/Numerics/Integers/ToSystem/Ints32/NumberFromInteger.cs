using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers;
using Tumbleweed.Scalars;

namespace TumbleSystem.Numerics.Integers.ToSystem.Ints32;

public sealed class NumberFromInteger : ScalarEnvelope<int>
{
	public NumberFromInteger(IInteger integer) : base
	(
		new NumberFromBits(
			new EnumerableWithElement<IBit>(
				integer.Natural,
				integer.Positive))
	)
	{
	}

}