using Tumbleweed.Enumerables;
using Tumbleweed.Numerics.Bits.FromSystem.FromSingles;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Decimals.FromSystem;

public sealed class DecimalsFromSingles : EnumerableEnvelope<IDecimal>
{
	public DecimalsFromSingles(IEnumerable<IScalar<float>> singles) : this
	(
		new ValuesOfScalars<float>(singles)
	)
	{
	}
	
	public DecimalsFromSingles(IEnumerable<float> singles) : base
	(
		new SelectedByExpression<float, IDecimal>(
			singles,
			single => new DecimalFromSingle(single))
	)
	{
	}
}