namespace Tumbleweed.Numerics.Fractional.FromEnumerable;

public class AggregatedByExpression : FractionalEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<IFractional> from,
		IFractional seed,
		Func<IFractional, IFractional, IFractional> expression
	) : base
	(
		new FractionalOfScalar(
			new Scalars.FromEnumerable.AggregatedByExpression<IFractional>(
				from,
				seed,
				expression))
	)
	{
	}
}