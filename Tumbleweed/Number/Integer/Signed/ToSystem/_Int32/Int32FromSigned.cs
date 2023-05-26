using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed.ToSystem._Int32;

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