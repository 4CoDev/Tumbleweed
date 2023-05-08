using Tumbleweed.Delegates.Functions.Binary;

namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class AggregatedByExpression<T> : ScalarEnvelope<T>
{
	public AggregatedByExpression
	(
		IEnumerable<T> from,
		T seed,
		Func<T, T, T> expression
	) : this
	(
		from,
		seed,
		new FunctionFromSystem<T, T, T>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<T> from,
		T seed,
		IFunction<T, T, T> expression
	) : base
	(
		new AggregatedByExpression<T, T>(from, seed, expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<T> from,
		Func<T, T, T> expression
	) : this
	(
		from,
		new FunctionFromSystem<T, T, T>(expression)
	)
	{
	}
	
	public AggregatedByExpression
	(
		IEnumerable<T> from,
		IFunction<T, T, T> expression
	) : base
	(
		new ResultOfFunction<T>(
			() => from.Aggregate(expression.ResultWith))
	)
	{
	}
}