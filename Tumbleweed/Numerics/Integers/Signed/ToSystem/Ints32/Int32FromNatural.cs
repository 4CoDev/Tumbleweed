using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromNatural : ScalarEnvelope<int>
{
	public Int32FromNatural(INaturalInteger natural) : base
	(
		new Int32FromBits(
			new EnumerableWithElement<IBit>(
				natural.Bits,
				new BitFromBoolean(false)))
	)
	{
	}

}