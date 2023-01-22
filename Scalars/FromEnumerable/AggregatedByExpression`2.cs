namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class AggregatedByExpression<TFrom, TAccumulate>
	: ScalarEnvelope<TAccumulate>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		TAccumulate seed,
		Func<TAccumulate, TFrom, TAccumulate> func
	) : base
	(
		new ScalarOfDelegate<TAccumulate>(
			() => from.Aggregate(seed, func))
	)
	{
	}
}