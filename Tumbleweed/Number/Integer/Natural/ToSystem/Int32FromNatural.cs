using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;
using Tumbleweed._Enumerable;
using Tumbleweed.Number.Integer.Signed.ToSystem._Int32;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Natural.ToSystem;

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