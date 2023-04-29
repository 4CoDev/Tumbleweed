using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromNatural : ScalarEnvelope<Int32>
{
	public Int32FromNatural(INaturalInteger natural) : base
	(
		new Int32FromBits(
			new EnumerableWithElement<IBoolean>(
				natural.Bits,
				new BooleanFromSystem(false)))
	)
	{
	}

}