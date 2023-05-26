namespace Tumbleweed.Number.Real.FromEnumerable;

public class AggregatedByExpression : RealEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<IReal> from,
		IReal seed,
		Func<IReal, IReal, IReal> expression
	) : base
	(
		new RealOfScalar(
			new Scalar.FromEnumerable.AggregatedByExpression<IReal>(
				from,
				seed,
				expression))
	)
	{
	}
}