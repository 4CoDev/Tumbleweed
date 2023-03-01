using Tumbleweed.Scalars.FromEnumerable;

namespace Tumbleweed.Numerics.Fractional.FromEnumerable;

public class AggregatedByExpression<TFrom> : FractionalEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IFractional seed,
		Func<IFractional, TFrom, IFractional> expression
	) : base
	(
		new FractionalOfScalar(
			new AggregatedByExpression<TFrom, IFractional>(from, seed, expression))
	)
	{
	}
}