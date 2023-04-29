using Tumbleweed.Delegates.Functions.Binary;

namespace Tumbleweed.Numerics.Spatial.FromEnumerables;

public sealed class AggregatedByExpression<TFrom, TTo>
	: SpatialEnvelope<TTo>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		ISpatial<TTo> seed,
		Func<ISpatial<TTo>, TFrom, ISpatial<TTo>> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<ISpatial<TTo>, TFrom, ISpatial<TTo>>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		ISpatial<TTo> seed,
		IBinaryFunction<ISpatial<TTo>, TFrom, ISpatial<TTo>> 
		expression
	) : base
	(
		new SpatialOfScalar<TTo>(
			new Scalars.FromEnumerable.AggregatedByExpression<TFrom, ISpatial<TTo>>(
					from,
					seed,
					expression))
	)
	{
	}
}