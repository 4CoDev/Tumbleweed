using Tumbleweed.Subroutines.Functions.Binary;

namespace Tumbleweed.Points.Spatial.FromEnumerables;

public sealed class AggregatedByExpression<TFrom, TTo>
	: PointEnvelope<TTo>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IPoint<TTo> seed,
		Func<IPoint<TTo>, TFrom, IPoint<TTo>> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<IPoint<TTo>, TFrom, IPoint<TTo>>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IPoint<TTo> seed,
		IFunction<IPoint<TTo>, TFrom, IPoint<TTo>> 
		expression
	) : base
	(
		new PointOfScalar<TTo>(
			new Scalars.FromEnumerable.AggregatedByExpression<TFrom, IPoint<TTo>>(
					from,
					seed,
					expression))
	)
	{
	}
}