using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Decimals.FromCollection.FromSystem;

public sealed class DecimalWithIndex : DecimalEnvelope
{
	public DecimalWithIndex
	(
		ICollection<IDecimal> decimals,
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
		ICollection<IDecimal> decimals,
		IScalar<int> index
	) : base
	(
		new DecimalOfDelegate(
			() => decimals.ElementAt(index.Value))
	)
	{
	}
}