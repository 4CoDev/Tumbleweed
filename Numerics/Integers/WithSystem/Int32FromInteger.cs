using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using Tumbleweed.WithSystem.Numerics.Ints32;
using Tumbleweed.WithSystem.Numerics.Ints32.FromTumbleweed;

namespace Tumbleweed.Numerics.Integers.WithSystem;

public sealed class Int32FromInteger : ScalarEnvelope<int>
{
	public Int32FromInteger(IInteger integer) : base
	(
		new NumberFromBits(
			new EnumerableWithElement<IBit>(
				integer.Natural,
				integer.Positive))
	)
	{
	}

}