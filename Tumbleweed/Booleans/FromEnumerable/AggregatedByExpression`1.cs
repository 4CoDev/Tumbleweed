using Tumbleweed.Delegates.Functions.Binary;
using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Booleans.FromEnumerable;

public sealed class AggregatedByExpression<TFrom>
	: BooleanEnvelope
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IBoolean seed,
		Func<IBoolean, TFrom, IBoolean> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<IBoolean, TFrom, IBoolean>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IBoolean seed,
		IBinaryFunction<IBoolean, TFrom, IBoolean> 
		expression
	) : base
	(
		new BooleanOfScalar(
			new Scalars.FromEnumerable.AggregatedByExpression<TFrom, IBoolean>(
				from,
				seed,
				expression))
	)
	{
	}
}