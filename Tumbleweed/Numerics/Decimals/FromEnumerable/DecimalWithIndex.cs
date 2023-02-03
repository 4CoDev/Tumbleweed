using Tumbleweed.Numerics.Integers;

namespace Tumbleweed.Numerics.Decimals.FromEnumerable;

public sealed class DecimalWithIndex : DecimalEnvelope
{
	public DecimalWithIndex
	(
		IEnumerable<IDecimal> decimals,
		IInteger index
	) : base
	(
		new FromCollection.DecimalWithIndex(
			new List<IDecimal>(decimals),
			index)
	)
	{
	}
}