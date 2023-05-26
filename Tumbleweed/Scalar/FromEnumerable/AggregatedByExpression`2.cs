using Tumbleweed.Subroutine.Function.Binary;

namespace Tumbleweed.Scalar.FromEnumerable;

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
		IFunction<TAccumulate, TFrom, TAccumulate> expression
	) : base
	(
		new ResultOfFunction<TAccumulate>(
			() => from.Aggregate(seed, expression.ResultWith))
	)
	{
	}
}