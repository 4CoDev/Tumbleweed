using Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Point.Spatial.FromEnumerable;

public sealed class AggregatedByExpression<T>
	: PointEnvelope<T>
{
	public AggregatedByExpression
	(
		IEnumerable<IPoint<T>> from,
		IPoint<T> seed,
		Func<IPoint<T>, IPoint<T>, IPoint<T>> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<IPoint<T>, IPoint<T>, IPoint<T>>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<IPoint<T>> from,
		IPoint<T> seed,
		IFunction<IPoint<T>, IPoint<T>, IPoint<T>> expression
	) : base
	(
		new PointOfScalar<T>(
			new Scalar.FromEnumerable.AggregatedByExpression<IPoint<T>>(
				from,
				seed,
				expression))
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<IPoint<T>> from,
		Func<IPoint<T>, IPoint<T>, IPoint<T>> expression
	) : this
	(
		from,
		new FunctionFromSystem<IPoint<T>, IPoint<T>, IPoint<T>>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<IPoint<T>> from,
		IFunction<IPoint<T>, IPoint<T>, IPoint<T>> expression
	) : base
	(
		new PointOfScalar<T>(
			new Scalar.FromEnumerable.AggregatedByExpression<IPoint<T>>(
				from,
				expression))
	)
	{
	}
}