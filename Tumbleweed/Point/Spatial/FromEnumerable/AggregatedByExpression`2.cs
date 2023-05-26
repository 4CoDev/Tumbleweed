using Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Point.Spatial.FromEnumerable;

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
			new Scalar.FromEnumerable.AggregatedByExpression<TFrom, IPoint<TTo>>(
					from,
					seed,
					expression))
	)
	{
	}
}