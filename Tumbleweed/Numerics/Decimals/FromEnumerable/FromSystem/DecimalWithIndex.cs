using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Decimals.FromEnumerable.FromSystem;

public sealed class DecimalWithIndex : DecimalEnvelope
{
	public DecimalWithIndex
	(
		IEnumerable<IDecimal> decimals,
		int index
	) : this
	(
		decimals,
		new ScalarOfValue<int>(index)
	)
	{
	}
	
	public DecimalWithIndex
	(
		IEnumerable<IDecimal> decimals,
		IScalar<int> index
	) : base
	(
		new FromCollection.FromSystem.DecimalWithIndex(
			new List<IDecimal>(decimals),
			index)
	)
	{
	}

}