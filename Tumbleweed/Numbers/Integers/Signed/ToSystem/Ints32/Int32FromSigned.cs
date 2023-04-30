using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromSigned : ScalarEnvelope<Int32>
{
	public Int32FromSigned(ISigned integer) : base
	(
		new Int32FromBits(
			new EnumerableWithElement<IBoolean>(
				integer.Natural.Bits,
				integer.IsPositive))
	)
	{
	}

}