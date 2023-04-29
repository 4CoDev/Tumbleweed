using Tumbleweed.Delegates.Functions.Binary;

namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class AggregatedByExpression<TFrom, TAccumulate>
	: ScalarEnvelope<TAccumulate>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		TAccumulate seed,
		Func<TAccumulate, TFrom, TAccumulate> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<TAccumulate, TFrom, TAccumulate>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		TAccumulate seed,
		IBinaryFunction<TAccumulate, TFrom, TAccumulate> expression
	) : base
	(
		new ValueOfFunction<TAccumulate>(
			() => from.Aggregate(seed, expression.Invoke))
	)
	{
	}
}