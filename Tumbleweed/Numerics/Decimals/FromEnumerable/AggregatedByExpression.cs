namespace Tumbleweed.Numerics.Decimals.FromEnumerable;

public class AggregatedByExpression : DecimalEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<IDecimal> from,
		IDecimal seed,
		Func<IDecimal, IDecimal, IDecimal> expression
	) : base
	(
		new DecimalOfScalar(
			new Scalars.FromEnumerable.AggregatedByExpression<IDecimal>(
				from,
				seed,
				expression))
	)
	{
	}
}