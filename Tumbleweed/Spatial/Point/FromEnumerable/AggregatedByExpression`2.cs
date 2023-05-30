using Tumbleweed.Subroutine.Binary.Function;

namespace Tumbleweed.Spatial.Point.FromEnumerable;

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