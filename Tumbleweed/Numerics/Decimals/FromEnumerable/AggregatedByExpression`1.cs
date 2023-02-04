using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Decimals.FromEnumerable;

public class AggregatedByExpression<TFrom> : DecimalEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IDecimal seed,
		Func<IDecimal, TFrom, IDecimal> expression
	) : base
	(
		new DecimalOfScalar(
			new AggregatedByExpression<TFrom, IDecimal>(from, seed, expression))
	)
	{
	}
}