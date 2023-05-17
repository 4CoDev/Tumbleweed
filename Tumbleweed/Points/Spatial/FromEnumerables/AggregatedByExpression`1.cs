using Tumbleweed.Subroutines.Functions.Binary;

namespace Tumbleweed.Points.Spatial.FromEnumerables;

public sealed class AggregatedByExpression<T>
	: SpatialEnvelope<T>
{
	public AggregatedByExpression
	(
		IEnumerable<ISpatial<T>> from,
		ISpatial<T> seed,
		Func<ISpatial<T>, ISpatial<T>, ISpatial<T>> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<ISpatial<T>, ISpatial<T>, ISpatial<T>>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<ISpatial<T>> from,
		ISpatial<T> seed,
		IFunction<ISpatial<T>, ISpatial<T>, ISpatial<T>> expression
	) : base
	(
		new SpatialOfScalar<T>(
			new Scalars.FromEnumerable.AggregatedByExpression<ISpatial<T>>(
				from,
				seed,
				expression))
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<ISpatial<T>> from,
		Func<ISpatial<T>, ISpatial<T>, ISpatial<T>> expression
	) : this
	(
		from,
		new FunctionFromSystem<ISpatial<T>, ISpatial<T>, ISpatial<T>>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<ISpatial<T>> from,
		IFunction<ISpatial<T>, ISpatial<T>, ISpatial<T>> expression
	) : base
	(
		new SpatialOfScalar<T>(
			new Scalars.FromEnumerable.AggregatedByExpression<ISpatial<T>>(
				from,
				expression))
	)
	{
	}
}