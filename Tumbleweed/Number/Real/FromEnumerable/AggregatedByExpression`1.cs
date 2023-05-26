using Tumbleweed.Scalar.FromEnumerable;

namespace Tumbleweed.Number.Real.FromEnumerable;

public class AggregatedByExpression<TFrom> : RealEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IReal seed,
		Func<IReal, TFrom, IReal> expression
	) : base
	(
		new RealOfScalar(
			new AggregatedByExpression<TFrom, IReal>(from, seed, expression))
	)
	{
	}
}