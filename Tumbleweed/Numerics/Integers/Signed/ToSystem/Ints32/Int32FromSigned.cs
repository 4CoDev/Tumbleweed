using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

public sealed class Int32FromSigned : ScalarEnvelope<Int32>
{
	public Int32FromSigned(ISignedInteger integer) : base
	(
		new Int32FromBits(
			new EnumerableWithElement<IBit>(
				integer.Natural.Bits,
				integer.Positive))
	)
	{
	}

}