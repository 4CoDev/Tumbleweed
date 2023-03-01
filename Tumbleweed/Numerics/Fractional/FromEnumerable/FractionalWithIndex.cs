using Tumbleweed.Numerics.Integers;
using Tumbleweed.Numerics.Integers.Signed;

namespace Tumbleweed.Numerics.Fractional.FromEnumerable;

public sealed class FractionalWithIndex : FractionalEnvelope
{
	public FractionalWithIndex
	(
		IEnumerable<IFractional> decimals,
		ISignedInteger index
	) : base
	(
		new FromCollection.FractionalWithIndex(
			new List<IFractional>(decimals),
			index)
	)
	{
	}
}