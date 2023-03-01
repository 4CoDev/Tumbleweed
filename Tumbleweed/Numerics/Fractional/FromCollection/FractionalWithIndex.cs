using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

namespace Tumbleweed.Numerics.Fractional.FromCollection;

public sealed class FractionalWithIndex : FractionalEnvelope
{
	public FractionalWithIndex
	(
		ICollection<IFractional> decimals,
		ISignedInteger index
	) : base
	(
		new FromSystem.FractionalWithIndex(
			decimals,
			new Int32FromSigned(index))
	)
	{
	}
}