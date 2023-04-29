using Tumbleweed.Delegates.Functions.Binary;

namespace Tumbleweed.Numerics.Spatial.FromEnumerables;

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
		IBinaryFunction<ISpatial<T>, ISpatial<T>, ISpatial<T>> expression
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
		IBinaryFunction<ISpatial<T>, ISpatial<T>, ISpatial<T>> expression
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