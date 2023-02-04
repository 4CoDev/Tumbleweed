using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.ToSystem.Ints32;

public sealed class Int32FromInteger : ScalarEnvelope<int>
{
	public Int32FromInteger(IInteger integer) : base
	(
		new Int32FromBits(
			new EnumerableWithElement<IBit>(
				integer.Natural,
				integer.Positive))
	)
	{
	}

}