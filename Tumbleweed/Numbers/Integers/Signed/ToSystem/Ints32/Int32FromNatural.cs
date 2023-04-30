using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromNatural : ScalarEnvelope<Int32>
{
	public Int32FromNatural(INatural natural) : base
	(
		new Int32FromBits(
			new EnumerableWithElement<IBoolean>(
				natural.Bits,
				new BooleanFromSystem(false)))
	)
	{
	}

}